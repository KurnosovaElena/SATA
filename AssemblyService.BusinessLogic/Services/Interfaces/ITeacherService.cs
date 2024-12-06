using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;

public interface ITeacherService
{
    Task<IEnumerable<TeacherModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<TeacherModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    Task<TeacherModel> AddAsync(TeacherModel model, CancellationToken cancellationToken);
    Task<TeacherModel> UpdateAsync(TeacherModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}