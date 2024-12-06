using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class DisciplineRepository(TimetableContext context) : RepositoryBase<Discipline>(context), IDisciplineRepository
{
    public async Task<IEnumerable<Discipline>> GetAllAsync(CancellationToken cancellationToken) =>
        await GetAllAsQueryable().ToListAsync(cancellationToken);

    public async Task<Discipline> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(d => d.Id == id).FirstAsync(cancellationToken);
    //метод для получения данных о слотах с ссылкой на дисциплину (с пагинацией)
    //метод для получения данных о слоте по id с ссылкой на на дисциплину
}

