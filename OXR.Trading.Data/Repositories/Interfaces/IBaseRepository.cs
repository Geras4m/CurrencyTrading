using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OXR.Trading.Data.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : class
    {
        Task<TEntity> SelectAsync(params object[] keyValues);

        IQueryable<TEntity> SelectAll();

        IQueryable<TEntity> SelectAll(Expression<Func<TEntity, bool>> predicate);

        bool Any(Expression<Func<TEntity, bool>> predicate);

        TEntity Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        Task DeleteAsync(params object[] keyValues);
        Task SaveChangesAsync();
    }
}
