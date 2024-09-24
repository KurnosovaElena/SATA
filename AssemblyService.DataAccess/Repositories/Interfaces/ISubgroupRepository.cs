using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface ISubgroupRepository : IRepositoryBase<Subgroup>
{
    Task<Subgroup> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
