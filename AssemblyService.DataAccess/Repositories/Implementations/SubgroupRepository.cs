using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class SubgroupRepository(TimetableContext context) : RepositoryBase<Subgroup>(context), ISubgroupRepository
{
    public async Task<Subgroup> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(sg => sg.Id == id).Include(sg => sg.Subjects).FirstAsync(cancellationToken);
}
