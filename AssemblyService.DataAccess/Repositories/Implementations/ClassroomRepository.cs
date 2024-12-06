using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class ClassroomRepository(TimetableContext context) : RepositoryBase<Classroom>(context), IClassroomRepository
{
    public async Task<Classroom> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(c => c.Id == id).FirstOrDefaultAsync(cancellationToken);
    //метод для получения данных об аудиториях с ссылкой на корпус (с пагинацией)
    //метод для получения данных об аудитории по id с ссылкой на корпус и детали об аудитории
}