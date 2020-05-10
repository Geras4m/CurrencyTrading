using System;
using System.Collections.Generic;
using OXR.Trading.WebApi.Models;
using OXR.Trading.Common.Mapper;
using OXR.Trading.Core.Dto;
using OXR.Trading.Core.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using OXR.Trading.Common.Exceptions;
using OXR.Trading.Common.Enum;
using OXR.Trading.Common.Helpers;
using OXR.Trading.Common.Extensions;
using OXR.Trading.WebApi.Models.RequestModels;
using Microsoft.Extensions.Options;
using OXR.Trading.WebApi.Models.Config;

namespace OXR.Trading.WebApi.Controllers
{
    [Route("api/v1/trades")]
    [ApiController]
    public class TradesController : ControllerBase
    {
        #region Fields, Constructors
        private readonly ITradeService _tradeService;
        private readonly ITradeFacade _tradeFacade;
        private readonly IMyMapper _mapper;
        private readonly IOptions<AppConfig> _appConfig;

        public TradesController(ITradeService tradeService, ITradeFacade tradeFacade, IMyMapper mapper, IOptions<AppConfig> appConfig)
        {
            _tradeService = tradeService ?? throw new ArgumentNullException(nameof(tradeService));
            _tradeFacade = tradeFacade ?? throw new ArgumentNullException(nameof(tradeFacade));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _appConfig = appConfig ?? throw new ArgumentNullException(nameof(mapper));
        }
        #endregion

        [HttpGet("{id}")]
        [ProducesResponseType(200, Type = typeof(TradeResponse))]
        public async Task<IActionResult> GetTradeById(int id)
        {
            var tradeDto = await _tradeService.GetAsync(id);
            if (tradeDto == null)
            {                
                throw new WebServiceException(ErrorCode.InvalidParameter, ConstantStrings.ERR_INCORRECT_ID);
            }
            return Ok(_mapper.Map<TradeResponse>(tradeDto));
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IList<TradeResponse>))]
        public IActionResult GetTrades()
        {
            var tradeDtos = _tradeService.GetAll();

            return Ok(_mapper.Map<IList<TradeResponse>>(tradeDtos));
        }

        [HttpPost("paged")]
        [ProducesResponseType(200, Type = typeof(IList<TradeResponse>))]
        public IActionResult GetTradesPaged([FromBody]PagingModel page)
        {
            var tradeDtos = _tradeService.GetAllPaged(page: page.PageNumber, size: page.PageSize);

            return Ok(_mapper.Map<IList<TradeResponse>>(tradeDtos));
        }

        [HttpPost("create")]
        [ProducesResponseType(201, Type = typeof(TradeResponse))]
        public async Task<IActionResult> CreateTrade([FromBody]TradeModel trade)
        {
            if (ModelState.IsValid)
            {
                var response = await _tradeFacade.CreateAsync(trade, _appConfig.Value.TotalEnrichmentPercent);
                return CreatedAtAction("CreateTrade", _mapper.Map<TradeResponse>(response));
            }
            else
                throw new WebServiceException(ErrorCode.InvalidParameters, "Invalid model.");
        }
    }
}
