using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface ISubgroupRepository : IRepositoryBase<Subgroup>
{
    Task<IEnumerable<Subgroup>> GetAllAsync(CancellationToken cancellationToken);
    Task<Subgroup> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
