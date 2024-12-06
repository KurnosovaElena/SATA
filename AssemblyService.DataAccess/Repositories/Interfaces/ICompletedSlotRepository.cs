using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface ICompletedSlotRepository : IRepositoryBase<CompletedSlot>
{
    Task<CompletedSlot?> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    //Task<IEnumerable<CompletedSlot>> GetAllCompletedSlotsOfSubjectsAsync();
}