using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;
public interface ITeacherService
{
    Task<IEnumerable<TeacherModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<TeacherModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
