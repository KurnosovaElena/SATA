using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;

public interface ISubgroupService
{
    Task<IEnumerable<SubgroupModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<SubgroupModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<SubgroupModel> AddAsync(SubgroupModel model, CancellationToken cancellationToken);
    Task<SubgroupModel> UpdateAsync(SubgroupModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}