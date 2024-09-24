using AssemblyService.DataAccess.Entities;
using System.Text.RegularExpressions;

namespace AssemblyService.DataAccess.Repositories.Interfaces;

public interface IGroupRepository : IRepositoryBase<GroupEntity>
{
    Task<IEnumerable<GroupEntity>> GetAllByDepartmentAsync(Guid departmentId, CancellationToken cancellationToken);
}