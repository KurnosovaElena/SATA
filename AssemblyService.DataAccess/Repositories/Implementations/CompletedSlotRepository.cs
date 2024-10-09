using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class CompletedSlotRepository(TimetableContext context) : RepositoryBase<CompletedSlot>(context), ICompletedSlotRepository
{
    //метод для получения данных о слотах с ссылкой на занятие и аудиторию (с пагинацией)
    //метод для получения данных о слоте по id с ссылкой на занятие и аудиторию
}
