using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;

public interface ISubjectService
{
    Task<IEnumerable<SubjectModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<SubjectModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<SubjectModel> AddAsync(SubjectModel model, CancellationToken cancellationToken);
    Task<SubjectModel> UpdateAsync(SubjectModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}
