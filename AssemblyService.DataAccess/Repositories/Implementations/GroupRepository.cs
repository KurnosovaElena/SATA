using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class GroupRepository(TimetableContext context) : RepositoryBase<GroupEntity>(context), IGroupRepository
{
    public async Task<IEnumerable<GroupEntity>> GetAllByDepartmentAsync(Guid departmentId, CancellationToken cancellationToken) =>
        await GetAllByConditionAsQueryable(g => g.DepartmentId == departmentId).ToListAsync(cancellationToken);
}
