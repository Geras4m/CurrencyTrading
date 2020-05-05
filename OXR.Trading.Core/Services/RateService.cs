using OXR.Trading.ApiFramework.Services.Interfaces;
using OXR.Trading.Common.Enum;
using OXR.Trading.Common.Mapper;
using OXR.Trading.Core.Dto;
using OXR.Trading.Core.Services.Interfaces;

namespace OXR.Trading.Core.Services
{
    public class RateService : IRateService
    {
        #region Fields/COnstructors
        private readonly ILatestRatesService _latestRatesService;
        private readonly IMyMapper _mapper;
        public RateService(ILatestRatesService latestRatesService, IMyMapper mapper)
        {
            _latestRatesService = latestRatesService;
            _mapper = mapper;
        }
        #endregion

        public LatestRatesDto GetLatestRates()
            => _mapper.Map<LatestRatesDto>(_latestRatesService.Get());

        public decimal GetBrokerRate(LatestRatesDto latestRates, Currency currency)
        {
            latestRates.Rates.TryGetValue(currency.ToString(), out decimal rate);
            return rate;
        }
    }
}
