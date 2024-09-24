using System.Linq.Expressions;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IGenericRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsListAsync(CancellationToken cancellationToken);

    Task<IEnumerable<TEntity>> GetByConditionAsListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
}
