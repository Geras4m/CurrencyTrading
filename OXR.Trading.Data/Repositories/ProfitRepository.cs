using OXR.Trading.Data.Entities;
using OXR.Trading.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OXR.Trading.Data.Repositories
{
    public class ProfitRepository : BaseRepository<DailyProfit>, IProfitRepository
    {
        public ProfitRepository(TradingDbContext context)
            : base(context)
        {
        }

        public IQueryable<DailyProfit> SelectByDate(DateTime startDate, DateTime endDate)
            => _entities.Where(p => p.DealDay >= startDate && p.DealDay <= endDate);
        
    }
}
