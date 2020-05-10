using OXR.Trading.Core.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services.Interfaces
{
    public interface IProfitFacade
    {
        IList<DailyProfitDto> GetProfitsByDate(DateTime startDate, DateTime endDate);
    }
}