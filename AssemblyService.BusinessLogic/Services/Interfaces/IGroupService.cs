using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;

public interface IGroupService
{
    Task<IEnumerable<GroupModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<GroupModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<GroupModel> AddAsync(GroupModel model, CancellationToken cancellationToken);
    Task<GroupModel> UpdateAsync(GroupModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}