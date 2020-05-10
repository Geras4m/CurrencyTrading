using OXR.Trading.Common.Mapper;
using OXR.Trading.Core.Services.Interfaces;
using OXR.Trading.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OXR.Trading.Core.Services
{
    public abstract class BaseService<TDto, TEntity> : IBaseService<TDto>
        where TDto : class
        where TEntity : class
    {
        #region Fields, Constructors
        protected readonly IBaseRepository<TEntity> _repository;
        protected readonly IMyMapper _mapper;
        internal BaseService(IBaseRepository<TEntity> repository, IMyMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        #endregion

        #region GET/Select methods

        public async Task<TDto> GetAsync(params object[] keyValues)
            => await OnGetAsync(keyValues);

        protected async virtual Task<TDto> OnGetAsync(params object[] keyValues)
            => _mapper.Map<TDto>(await _repository.SelectAsync(keyValues));
        
        public IList<TDto> GetAll()
            => OnGetAll();

        protected virtual IList<TDto> OnGetAll()
            => _mapper.Map<IList<TDto>>(_repository.SelectAll());

        public IList<TDto> GetAll(Expression<Func<TDto, bool>> predicate)
            => OnGetAll(predicate);

        protected virtual IList<TDto> OnGetAll(Expression<Func<TDto, bool>> predicate)
        {
            Expression<Func<TEntity, bool>> pred = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            var entities = _repository.SelectAll(pred);

            return _mapper.Map<IList<TDto>>(entities);
        }

        #endregion

        public bool Any(Expression<Func<TDto, bool>> predicate)
            => OnAny(predicate);

        protected virtual bool OnAny(Expression<Func<TDto, bool>> predicate)
        {
            var expression = _mapper.Map<Expression<Func<TEntity, bool>>>(predicate);
            return _repository.Any(expression);
        }

        #region Add, Remove, Modify Methods

        public TDto Add(TDto dtoModel) 
            => OnAdd(dtoModel);

        protected virtual TDto OnAdd(TDto dtoModel)
            => _mapper.Map<TDto>(_repository.Insert(_mapper.Map<TEntity>(dtoModel)));
        
        public void Modify(TDto dtoModel) 
            => OnModify(dtoModel);

        protected virtual void OnModify(TDto dtoModel) 
            => _repository.Update(_mapper.Map<TEntity>(dtoModel));

        public async Task RemoveAsync(params object[] keyValues)
            => await OnRemove(keyValues);

        protected virtual async Task OnRemove(params object[] keyValues) 
            => await _repository.DeleteAsync(keyValues);

        public void Remove(TDto dtoModel) 
            => OnRemove(dtoModel);

        protected virtual void OnRemove(TDto dtoModel)
            => _repository.Delete(_mapper.Map<TEntity>(dtoModel));

        public async Task SaveChangesAsync() 
            => await OnSaveChangesAsync();

        protected async virtual Task OnSaveChangesAsync()
            => await _repository.SaveChangesAsync();

        #endregion
    }
}
