using Microsoft.Extensions.Options;
using OXR.Trading.Common.Enum;
using OXR.Trading.Common.Extensions;
using OXR.Trading.Core.Dto;
using OXR.Trading.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services
{
    public class TradeFacade : ITradeFacade
    {
        private readonly ITradeService _tradeService;
        private readonly IRateService _rateService;

        public TradeFacade(ITradeService tradeService, IRateService rateService)
        {
            _tradeService = tradeService;
            _rateService = rateService;
        }

        public async Task<TradeDto> CreateAsync(TradeModel tradeModel, decimal totalEnrichmentPercent)
        {
            var trade = new TradeDto()
            {
                SellingCurrency = tradeModel.SellingCurrency.ToEnum<Currency>(true),
                BuyingCurrency = tradeModel.BuyingCurrency.ToEnum<Currency>(true),
                SoldAmount = tradeModel.SoldAmount,
                ClientName = tradeModel.ClientName
            };
            var latestRates = _rateService.GetLatestRates();
            var rateBuyingCurrency = _rateService.GetBrokerRate(latestRates, trade.BuyingCurrency);
            var rateGBP = _rateService.GetBrokerRate(latestRates, Currency.GBP);

            trade.BrokerRate = _rateService.GetBrokerRate(latestRates, trade.SellingCurrency) / rateBuyingCurrency;
            trade.PurchasedAmount = trade.SoldAmount / (trade.BrokerRate / (1M + (totalEnrichmentPercent / 100)));
            trade.ProfitInBuyingCurrency = trade.PurchasedAmount - (trade.SoldAmount / trade.BrokerRate);
            trade.ProfitInGBP = trade.ProfitInBuyingCurrency / (rateBuyingCurrency / rateGBP);

            var result = _tradeService.AddOnDate(trade);
            await _tradeService.SaveChangesAsync();

            return result;
        }
    }
}
