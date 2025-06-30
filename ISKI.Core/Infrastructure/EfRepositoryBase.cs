using ISKI.Core.Persistence.Paging;
using ISKI.Core.Persistence.Dynamic;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using ISKI.Core.Domain;

namespace ISKI.Core.Infrastructure;

public class EfRepositoryBase<TEntity, TEntityId, TContext>(TContext context) : IAsyncRepository<TEntity, TEntityId>
    where TEntity : BaseEntity<TEntityId>
    where TContext : DbContext
{
    protected readonly TContext _context = context;

    public virtual async Task<PaginatedList<TEntity>> GetAllAsync(int pageNumber, int pageSize)
    {
        var query = _context.Set<TEntity>().Where(x => x.DeletedAt == null);

        var totalCount = await query.CountAsync();
        var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

        var data = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PaginatedList<TEntity>
        {
            Items = data,
            Index = pageNumber,
            Size = pageSize,
            Count = totalCount,
            Pages = totalPages
        };
    }

    public virtual async Task<PaginatedList<TEntity>> GetAllAsync(int pageNumber, int pageSize, DynamicQuery dynamicQuery)
    {
        var query = _context.Set<TEntity>().Where(x => x.DeletedAt == null);

        query = query.ApplyDynamicQuery(dynamicQuery);

        var totalCount = await query.CountAsync();
        var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

        var data = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return new PaginatedList<TEntity>
        {
            Items = data,
            Index = pageNumber,
            Size = pageSize,
            Count = totalCount,
            Pages = totalPages
        };
    }

    public virtual async Task<List<TEntity>> GetAllAsync(
    Expression<Func<TEntity, bool>> predicate,
    Func<IQueryable<TEntity>, IQueryable<TEntity>>? include = null)
    {
        IQueryable<TEntity> query = _context.Set<TEntity>();

        if (include is not null)
            query = include(query);

        return await query.Where(predicate).ToListAsync();
    }

    public virtual async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return await _context.Set<TEntity>().FirstOrDefaultAsync(predicate);
    }

    public virtual async Task<TEntity?> GetByIdAsync(TEntityId id)
    {
        return await _context.Set<TEntity>()
            .FirstOrDefaultAsync(x => x.Id.Equals(id) && x.DeletedAt == null);
    }

    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        entity.UpdatedAt = DateTime.UtcNow;
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public virtual async Task<TEntity?> DeleteAsync(TEntity entity)
    {
        var existingEntity = await _context.Set<TEntity>().FindAsync(entity.Id);
        if (existingEntity == null)
            return null;

        existingEntity.DeletedAt = DateTime.UtcNow;
        await _context.SaveChangesAsync();
        return existingEntity;
    }
}