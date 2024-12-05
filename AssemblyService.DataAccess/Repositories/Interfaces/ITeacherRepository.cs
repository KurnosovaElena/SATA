using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface ITeacherRepository : IRepositoryBase<Teacher>
{
    Task<IEnumerable<Teacher>> GetAllAsync(CancellationToken cancellationToken);
    Task<Teacher> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}