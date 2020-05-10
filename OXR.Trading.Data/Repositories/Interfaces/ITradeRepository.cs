using OXR.Trading.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OXR.Trading.Data.Repositories.Interfaces
{
    public interface ITradeRepository : IBaseRepository<Trade>
    {
        IQueryable<Trade> SelectAllPaged(int page = 1, int size = 3);
        IQueryable<Trade> SelectTradesByDate(DateTime date);
        Trade InsertOnDate(Trade entity);
    }
}
