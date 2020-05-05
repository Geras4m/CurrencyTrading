using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OXR.Trading.Data.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable
        where TEntity : class
    {
        /// <summary>
        /// Asynchronously returns the only entity from DbSet that satisfies the specified condition.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        Task<TEntity> SelectAsync(params object[] keyValues);

        /// <summary>
        /// Returns all entities in DbSet.
        /// </summary>
        /// <returns></returns>
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
