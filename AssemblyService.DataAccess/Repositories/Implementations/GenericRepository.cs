using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AssemblyService.DataAccess.Repositories.Implementations;
public class GenericRepository<TEntity>(TimetableContext context) : RepositoryBase<TEntity>(context), IGenericRepository<TEntity> where TEntity : class
{
    public async Task<IEnumerable<TEntity>> GetAllAsListAsync(CancellationToken cancellationToken) =>
        await GetAll().ToListAsync(cancellationToken);

    public async Task<IEnumerable<TEntity>> GetByConditionAsListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(predicate).ToListAsync(cancellationToken);
}