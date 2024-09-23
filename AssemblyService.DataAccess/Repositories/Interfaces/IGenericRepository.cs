using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IGenericRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsListAsync(CancellationToken cancellationToken);

    Task<IEnumerable<TEntity>> GetByConditionAsListAsync(Expression<Func<TEntity, bool>> predicate, CancellationToken cancellationToken);
}
