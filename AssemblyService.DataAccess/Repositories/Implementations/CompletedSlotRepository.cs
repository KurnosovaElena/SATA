using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class CompletedSlotRepository(TimetableContext context) : RepositoryBase<CompletedSlot>(context), ICompletedSlotRepository
{

    public async Task<CompletedSlot?> GetByIdAsync(Guid id, CancellationToken cancellationToken) =>
        await GetByConditionAsQueryable(e => e.Id == id).FirstOrDefaultAsync(cancellationToken);
    //метод для получения данных о слотах с ссылкой на занятие и аудиторию (с пагинацией)
    //метод для получения данных о слоте по id с ссылкой на занятие и аудиторию


}
