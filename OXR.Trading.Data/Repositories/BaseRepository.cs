using OXR.Trading.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

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
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _entities = context.Set<TEntity>();
        }
        #endregion

        #region Read/Select methods

        public async Task<TEntity> SelectAsync(params object[] keyValues)
        {
            var result = await _entities.FindAsync(keyValues);
            return result;
        }
          

        public IQueryable<TEntity> SelectAll() => _entities;

        public IQueryable<TEntity> SelectAll(Expression<Func<TEntity, bool>> predicate)
            => _entities.Where(predicate);

        #endregion

        public bool Any(Expression<Func<TEntity, bool>> predicate)
            => _entities.Any(predicate);

        #region C-UD Methods

        public TEntity Insert(TEntity entity)
            => _entities.AddAsync(entity).Result.Entity;

        public void Update(TEntity entity)
            => _context.Entry(entity).State = EntityState.Modified;

        public async Task DeleteAsync(params object[] keyValues)
            => _entities.Remove(await _entities.FindAsync(keyValues));

        public void Delete(TEntity entity)
            => _entities.Remove(entity);

        public async Task SaveChangesAsync()
            => await _context.SaveChangesAsync();

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
