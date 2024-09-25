using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;
public interface ITeacherService
{
    Task<TeacherModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
