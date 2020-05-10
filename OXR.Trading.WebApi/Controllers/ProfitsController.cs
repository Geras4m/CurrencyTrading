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
        private readonly IProfitFacade _profitFacade;
        private readonly IMyMapper _mapper;

        public ProfitsController(IProfitService profitService, IProfitFacade profitFacade, IMyMapper mapper)
        {
            _profitService = profitService ?? throw new ArgumentNullException(nameof(profitService));
            _profitFacade = profitFacade ?? throw new ArgumentNullException(nameof(profitFacade));
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
            var profitDtos = _profitFacade.GetProfitsByDate(startDate, endDate);

            return Ok(_mapper.Map<IList<DailyProfitResponse>>(profitDtos));
        }
    }
}