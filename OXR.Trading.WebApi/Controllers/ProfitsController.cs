using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OXR.Trading.Common.Mapper;
using OXR.Trading.Core.Services.Interfaces;
using OXR.Trading.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OXR.Trading.WebApi.Controllers
{
    [Route("api/v1/profits")]
    [ApiController]
    public class ProfitsController : ControllerBase
    {
        #region Fields, Constructors
        private readonly IProfitService _profitService;
        private readonly ITradeService _tradeService;
        private readonly IMyMapper _mapper;

        public ProfitsController(IProfitService profitService, ITradeService tradeService, IMyMapper mapper)
        {
            _profitService = profitService ?? throw new ArgumentNullException(nameof(profitService));
            _tradeService = tradeService ?? throw new ArgumentNullException(nameof(tradeService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        #endregion

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IList<DailyProfitResponse>))]
        public IActionResult GetProfits()
        {
            var profitDtos = _profitService.GetAll();

            return Ok(_mapper.Map<IList<DailyProfitResponse>>(profitDtos));
        }

        [HttpGet("dates")]
        [ProducesResponseType(200, Type = typeof(IList<DailyProfitResponse>))]
        public IActionResult GetProfitsByDate(DateTime startDate, DateTime endDate)
        {
            if (endDate.Date == DateTime.Now.Date)
            {
                var yesterday = endDate.AddDays(-1);
                var profitDtosUpToday = _profitService.GetByDate(startDate, yesterday);
                var result = _mapper.Map<IList<DailyProfitResponse>>(profitDtosUpToday);
                var trades = _tradeService.GetTradesByDate(endDate);

                if (!trades.Any())
                    return Ok(result);

                else if (trades.Count > 1)
                {
                    decimal profitToday = 0M;
                    foreach (var item in trades)
                        profitToday += item.ProfitInGBP;
                    
                    result.Add(new DailyProfitResponse() { DealDay = DateTime.Now, ProfitInGBP = profitToday });
                    return Ok(result);
                }
                else
                {
                    result.Add(new DailyProfitResponse() { DealDay = DateTime.Now, ProfitInGBP = trades.FirstOrDefault().ProfitInGBP });
                    return Ok(result);
                }
            }
            else
            {
                var profitDtos = _profitService.GetByDate(startDate, endDate);
                return Ok(_mapper.Map<IList<DailyProfitResponse>>(profitDtos));
            }

        }
    }
}