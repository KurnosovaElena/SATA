using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;
public class TeacherRepository(TimetableContext context) : RepositoryBase<Teacher>(context), ITeacherRepository
{
    public async Task<IEnumerable<Teacher>> GetAllAsync(CancellationToken cancellationToken) =>
        await GetAllAsQueryable().ToListAsync(cancellationToken);

    public async Task<Teacher> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(t => t.Id == id).Include(t => t.Subjects).FirstAsync(cancellationToken);

    //метод для получения данных о преподах с ссылкой на кафедру (с пагинацией)
}
