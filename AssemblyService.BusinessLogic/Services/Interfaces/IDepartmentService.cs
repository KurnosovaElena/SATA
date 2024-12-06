using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;

public interface IDepartmentService
{
    Task<DepartmentModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<IEnumerable<DepartmentModel>> GetAllAsync(CancellationToken cancellationToken);

    Task<DepartmentModel> AddAsync(DepartmentModel model, CancellationToken cancellationToken);

    Task<DepartmentModel> UpdateAsync(DepartmentModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}