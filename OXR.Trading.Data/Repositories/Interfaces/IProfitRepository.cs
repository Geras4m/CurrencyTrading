using OXR.Trading.Data.Entities;
using System;
using System.Linq;

namespace OXR.Trading.Data.Repositories.Interfaces
{
    public interface IProfitRepository : IBaseRepository<DailyProfit>
    {
        IQueryable<DailyProfit> SelectByDate(DateTime startDate, DateTime endDate);
    }
}
