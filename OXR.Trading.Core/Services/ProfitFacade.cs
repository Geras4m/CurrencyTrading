using OXR.Trading.Core.Dto;
using OXR.Trading.Core.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services
{
    class ProfitFacade : IProfitFacade
    {
        private readonly ITradeService _tradeService;
        private readonly IProfitService _profitService;

        public ProfitFacade(ITradeService tradeService, IProfitService profitService)
        {
            _tradeService = tradeService;
            _profitService = profitService;
        }

        public IList<DailyProfitDto> GetProfitsByDate(DateTime startDate, DateTime endDate)
        {
            if (endDate.Date == DateTime.Now.Date)
            {
                var yesterday = endDate.AddDays(-1);
                var result = _profitService.GetByDate(startDate, yesterday);
                var trades = _tradeService.GetTradesByDate(endDate);

                if (!trades.Any())
                    return result;

                else if (trades.Count > 1)
                {
                    decimal profitToday = 0M;
                    foreach (var item in trades)
                        profitToday += item.ProfitInGBP;

                    result.Add(new DailyProfitDto() { DealDay = DateTime.Now, ProfitInGBP = profitToday });
                    return result;
                }
                else
                {
                    result.Add(new DailyProfitDto() { DealDay = DateTime.Now, ProfitInGBP = trades.FirstOrDefault().ProfitInGBP });
                    return result;
                }
            }
            else
            {
                var profitDtos = _profitService.GetByDate(startDate, endDate);
                return profitDtos;
            }
        }
    }
}
