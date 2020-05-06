using OXR.Trading.Common.Enum;
using OXR.Trading.Common.Exceptions;
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
        {
            try
            {
                return _entities.Where(p => p.DealDay >= startDate && p.DealDay <= endDate);
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ErrorCode.InternalError, ex.Message, ex);
            }
        }
    }
}
