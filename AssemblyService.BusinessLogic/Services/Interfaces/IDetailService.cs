using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;
public interface IDetailService
{
    Task<IEnumerable<DetailModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<DetailModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<DetailModel> AddAsync(DetailModel model, CancellationToken cancellationToken);
    Task<DetailModel> UpdateAsync(DetailModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}