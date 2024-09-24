using AssemblyService.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface ISubgroupRepository : IRepositoryBase<Subgroup>
{
    Task<Subgroup> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
