using System.Linq.Expressions;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    IQueryable<TEntity> GetAllAsQueryable();

    IQueryable<TEntity> GetRangeAsQueryable(int pageNumber, int pageSize);

    IQueryable<TEntity> GetByConditionAsQueryable(Expression<Func<TEntity, bool>> predicate);

    IQueryable<TEntity> GetAllByConditionAsQueryable(Expression<Func<TEntity, bool>> predicate);

    Task<bool> IsAnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    Task Add(TEntity entity, CancellationToken cancellationToken);

    void Update(TEntity entity);

    void Delete(TEntity entity);
}