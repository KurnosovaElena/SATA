using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IClassroomRepository : IRepositoryBase<Classroom>
{
    Task<Classroom> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
