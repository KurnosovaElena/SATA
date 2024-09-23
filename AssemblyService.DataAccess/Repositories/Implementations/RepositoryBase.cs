using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AssemblyService.DataAccess.Repositories.Implementations;

    public class RepositoryBase<TEntity>(TimetableContext context) : IRepositoryBase<TEntity> where TEntity : class
    {
        public IQueryable<TEntity> GetAll() =>
            context.Set<TEntity>();

        public async Task<TEntity?> GetByConditionAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken) =>
            await context.Set<TEntity>().FirstOrDefaultAsync(predicate, cancellationToken);

        public IQueryable<TEntity> GetByConditionAsQueryable(Expression<Func<TEntity, bool>> predicate) =>
            context.Set<TEntity>().Where(predicate);

        public async Task<bool> IsAnyAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken) =>
            await context.Set<TEntity>().AnyAsync(predicate, cancellationToken);

        public async Task Add(TEntity entity, CancellationToken cancellationToken)
        {
            await context.Set<TEntity>().AddAsync(entity, cancellationToken);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
    }