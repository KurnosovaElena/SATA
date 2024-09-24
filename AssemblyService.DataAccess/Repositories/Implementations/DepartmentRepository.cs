using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class DepartmentRepository(TimetableContext context) : RepositoryBase<Department>(context), IDepartmentRepository
{
    public async Task<IEnumerable<Department>> GetAllAsync(CancellationToken cancellationToken) =>
        await GetAllAsQueryable().ToListAsync(cancellationToken);

    public async Task<Department> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(d => d.Id == id).Include(d => d.Groups).FirstAsync(cancellationToken);
}