using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;

public interface ICompletedSlotService
{
    Task<IEnumerable<CompletedSlotModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<CompletedSlotModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<CompletedSlotModel> AddAsync(CompletedSlotModel model, CancellationToken cancellationToken);
    Task<CompletedSlotModel> UpdateAsync(CompletedSlotModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}