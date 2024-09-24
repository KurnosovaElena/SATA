using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IGroupRepository : IRepositoryBase<GroupEntity>
{
    Task<IEnumerable<GroupEntity>> GetAllByDepartmentAsync(Guid departmentId, CancellationToken cancellationToken);
}