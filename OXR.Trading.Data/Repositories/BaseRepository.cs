using OXR.Trading.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using OXR.Trading.Common.Exceptions;
using OXR.Trading.Common.Enum;
using System.Collections.Generic;

namespace OXR.Trading.Data.Repositories
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity>
            where TEntity : class
    {
        #region Private Fields, Constructors
        protected readonly DbContext _context;
        protected readonly DbSet<TEntity> _entities;

        protected BaseRepository(DbContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }
        #endregion

        #region Read/Select methods

        public async Task<TEntity> SelectAsync(params object[] keyValues)
        {
            try
            {
                var result = await _entities.FindAsync(keyValues);
                return result;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ErrorCode.InternalError, ex.Message, ex);
            }
        }
        
        
        public IQueryable<TEntity> SelectAll() => _entities;

        public IQueryable<TEntity> SelectAll(Expression<Func<TEntity, bool>> predicate)
        {
            try
            {
                var entities = _entities.Where(predicate);
                return entities;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ErrorCode.InternalError, ex.Message, ex);
            }
        }

        #endregion

        public bool Any(Expression<Func<TEntity, bool>> predicate)
            => _entities.Any(predicate);

        #region C-UD Methods

        public TEntity Insert(TEntity entity)
        {
            try
            {
                return _entities.AddAsync(entity).Result.Entity;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ErrorCode.InternalError, ex.Message, ex);
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ErrorCode.InternalError, ex.Message, ex);
            }
        }

        public async Task DeleteAsync(params object[] keyValues)
        {
            try
            {
                _entities.Remove(await _entities.FindAsync(keyValues));
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ErrorCode.InternalError, ex.Message, ex);
            }
        }

        public void Delete(TEntity entity)
        {
            try
            {
                _entities.Remove(entity);
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ErrorCode.InternalError, ex.Message, ex);
            }
        }

        public async Task SaveChangesAsync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new DataAccessException(ErrorCode.InternalError, ex.Message, ex);
            }
        }

        #endregion

        #region Disposabel NVI
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_entities != null)
                    _context.Dispose();
            }
        }
        #endregion
    }
}
