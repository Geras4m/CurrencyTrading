using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services.Interfaces
{
    public interface IBaseService<TDto>
        where TDto : class
    {
        /// <summary>
        /// Returns element by keyValues.
        /// </summary>
        /// <param name="keyValues"></param>
        /// <returns></returns>
        Task<TDto> GetAsync(params object[] keyValues);

        /// <summary>
        /// Returns all elements.
        /// </summary>
        /// <returns></returns>
        IList<TDto> GetAll();

        /// <summary>
        /// Returns elements filtered based on predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IList<TDto> GetAll(Expression<Func<TDto, bool>> predicate);

        /// <summary>
        /// Returns true if any element of a sequence satisfies a condition;
        ///     otherwise, false.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool Any(Expression<Func<TDto, bool>> predicate);

        /// <summary>
        /// Adds new element after saving changes.
        /// </summary>
        /// <param name="dtoModel"></param>
        /// <returns></returns>
        TDto Add(TDto dtoModel);
                
        void Modify(TDto dtoModel);

        /// <summary>
        /// Marks to removes selected element after saving changes.
        /// </summary>
        /// <param name="dtoModel"></param>
        void Remove(TDto dtoModel);

        /// <summary>
        /// Removes element with give key after SaveChangesAsync() was called.
        /// </summary>
        /// <param name="keyValue"></param>
        /// <returns></returns>
        Task RemoveAsync(params object[] keyValue);

        /// <summary>
        /// Saves all changes.
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync();
    }
}
