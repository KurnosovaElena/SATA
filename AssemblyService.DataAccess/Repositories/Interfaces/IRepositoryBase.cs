using System.Linq.Expressions;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    IQueryable<TEntity> GetAll();

    Task<TEntity?> GetByConditionAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    IQueryable<TEntity> GetByConditionAsQueryable(Expression<Func<TEntity, bool>> predicate);

    Task<bool> IsAnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

    Task Add(TEntity entity, CancellationToken cancellationToken);

    void Delete(TEntity entity);
}