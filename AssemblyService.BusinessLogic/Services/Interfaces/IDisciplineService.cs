using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;
public interface IDisciplineService
{
    Task<IEnumerable<DisciplineModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<DisciplineModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<DisciplineModel> AddAsync(DisciplineModel model, CancellationToken cancellationToken);
    Task<DisciplineModel> UpdateAsync(DisciplineModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
