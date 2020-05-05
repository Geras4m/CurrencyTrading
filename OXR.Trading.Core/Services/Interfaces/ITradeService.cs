using OXR.Trading.Core.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace OXR.Trading.Core.Services.Interfaces
{
    public interface ITradeService : IBaseService<TradeDto>
    {
        IList<TradeDto> GetAllPaged(int page = 1, int size = 3);
        TradeDto AddOnDate(TradeDto trade);
    }
}
