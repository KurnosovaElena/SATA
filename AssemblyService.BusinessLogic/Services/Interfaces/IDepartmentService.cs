using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;

public interface IDepartmentService
{
    Task<DepartmentModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
