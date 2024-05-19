using System.Linq.Expressions;

namespace AssemblyService.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken);

        Task<TEntity?> GetByConditionAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        Task<IEnumerable<TEntity>> GetListByConditionAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        Task<bool> IsAnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);

        Task Add(TEntity entity, CancellationToken cancellationToken);

        void Delete(TEntity entity);
    }
}