using OXR.Trading.Core.Dto;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services.Interfaces
{
    public interface ITradeFacade
    {
        Task<TradeDto> CreateAsync(TradeModel tradeModel, decimal totalEnrichmentPercent);
    }
}