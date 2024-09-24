using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class RepositoryBase<TEntity>(TimetableContext context) : IRepositoryBase<TEntity> where TEntity : class
{
    public IQueryable<TEntity> GetAllAsQueryable() =>
        context.Set<TEntity>().AsNoTracking();

    public IQueryable<TEntity> GetRangeAsQueryable(int pageNumber, int pageSize)
    {
        var rowsToSkip = (pageNumber - 1) * pageSize;

        return context.Set<TEntity>()
            .Skip(rowsToSkip)
            .Take(pageSize)
            .AsNoTracking();
    }

    public IQueryable<TEntity> GetByConditionAsQueryable(Expression<Func<TEntity, bool>> predicate) =>
        context.Set<TEntity>().AsNoTracking().Where(predicate);

    public IQueryable<TEntity> GetAllByConditionAsQueryable(Expression<Func<TEntity, bool>> predicate) =>
        context.Set<TEntity>().Where(predicate).AsNoTracking();

    public async Task<bool> IsAnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken) =>
        await context.Set<TEntity>().AnyAsync(predicate, cancellationToken);

    public async Task Add(TEntity entity, CancellationToken cancellationToken)
    {
        await context.Set<TEntity>().AddAsync(entity, cancellationToken);
    }

    public void Update(TEntity entity) =>
        context.Set<TEntity>().Update(entity);

    public void Delete(TEntity entity)
    {
        context.Set<TEntity>().Remove(entity);
    }
}