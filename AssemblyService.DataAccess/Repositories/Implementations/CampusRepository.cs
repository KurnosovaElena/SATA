using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class CampusRepository(TimetableContext context) : RepositoryBase<Campus>(context), ICampusRepository
{
    public async Task<Campus> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(d => d.Id == id).FirstAsync(cancellationToken);

}
