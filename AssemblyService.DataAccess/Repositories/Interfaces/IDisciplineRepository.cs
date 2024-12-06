using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IDisciplineRepository : IRepositoryBase<Discipline>
{
    Task<IEnumerable<Discipline>> GetAllAsync(CancellationToken cancellationToken);

    Task<Discipline> GetByIdAsync(Guid id, CancellationToken cancellationToken);

}