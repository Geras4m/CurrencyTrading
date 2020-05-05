﻿using OXR.Trading.Common.Enum;
using OXR.Trading.Common.Exceptions;
using OXR.Trading.Data.Entities;
using OXR.Trading.Data.Repositories.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OXR.Trading.Data.Repositories
{
    public class TradeRepository : BaseRepository<Trade>, ITradeRepository
    {
        public TradeRepository(TradingDbContext context)
            : base(context)
        {
        }

        public IQueryable<Trade> SelectAllPaged(int page = 1, int size = 3)
        {
            var count = _entities.Count();

            if (page > 0 && size > 0)
            {
                var lastPage = (count % size == 0) ? count / size : count / size + 1;
                if(size <= count)
                {
                    if (page == 1)
                        return _entities.Take(size);
                    else if (page > 1 && page <= lastPage)
                        return _entities.Skip(size * (page - 1)).Take(size);
                    else
                        throw new DataAccessException(ErrorCode.InvalidPageNumber, $"Page number cannot be greater than {lastPage}.");
                }
                else
                    throw new DataAccessException(ErrorCode.InvalidPageNumber, $"Page size cannot be greater than {count}.");
            }
            else
                throw new DataAccessException(ErrorCode.InvalidPageNumber, $"Page number and size cannot be less than 1.");
        }

        public Trade InsertOnDate(Trade entity)
        {
            entity.DealDate = DateTime.Now;
            return _entities.AddAsync(entity).Result.Entity;
        }
    }
}
