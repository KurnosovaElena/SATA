using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;
public interface IClassroomService
{
    Task<IEnumerable<ClassroomModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<ClassroomModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<ClassroomModel> AddAsync(ClassroomModel model, CancellationToken cancellationToken);
    Task<ClassroomModel> UpdateAsync(ClassroomModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
