using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;
public class TeacherRepository(TimetableContext context) : RepositoryBase<Teacher>(context), ITeacherRepository
{
    public async Task<Teacher> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(t => t.Id == id).Include(t => t.Subjects).FirstAsync(cancellationToken);
}
