using ISKI.Core.Persistence.Dynamic;
using ISKI.Core.Persistence.Paging;
using System.Linq.Expressions;

namespace ISKI.Core.Infrastructure;

public interface IAsyncRepository<TEntity, TEntityId>
{
    Task<PaginatedList<TEntity>> GetAllAsync(int pageNumber, int pageSize);
    Task<PaginatedList<TEntity>> GetAllAsync(int pageNumber, int pageSize, DynamicQuery dynamicQuery);
    Task<List<TEntity>> GetAllAsync(
    Expression<Func<TEntity, bool>> predicate,
    Func<IQueryable<TEntity>, IQueryable<TEntity>>? include = null);
    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate);
    Task<TEntity?> GetByIdAsync(TEntityId id);
    Task<TEntity> AddAsync(TEntity entity);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity?> DeleteAsync(TEntity entity);
}
