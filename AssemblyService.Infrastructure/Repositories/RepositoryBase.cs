using AssemblyService.Domain.Interfaces.Repositories;
using AssemblyService.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Infrastructure.Repositories
{
    public class RepositoryBase<TEntity>(TimetableContext context) : IRepositoryBase<TEntity> where TEntity : class
    {
        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken cancellationToken) =>
            await context.Set<TEntity>().ToListAsync(cancellationToken);

        public async Task<TEntity?> GetByConditionAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken) =>
            await context.Set<TEntity>().FirstOrDefaultAsync(predicate, cancellationToken);

        public async Task Add(TEntity entity, CancellationToken cancellationToken)
        {
            await context.Set<TEntity>().AddAsync(entity);
        }

        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
    }
}