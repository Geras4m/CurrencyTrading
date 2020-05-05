using OXR.Trading.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OXR.Trading.Data.Repositories.Interfaces
{
    public interface IProfitRepository : IBaseRepository<DailyProfit>
    {
        IQueryable<DailyProfit> SelectByDate(DateTime startDate, DateTime endDate);
    }
}
