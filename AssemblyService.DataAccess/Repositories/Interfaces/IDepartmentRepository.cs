using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IDepartmentRepository : IRepositoryBase<Department>
{
    Task<IEnumerable<Department>> GetAllAsync(CancellationToken cancellationToken);

    Task<Department> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}