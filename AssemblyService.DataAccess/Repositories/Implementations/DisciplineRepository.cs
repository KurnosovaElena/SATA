using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class DisciplineRepository(TimetableContext context) : RepositoryBase<Discipline>(context), IDisciplineRepository
{
    //метод для получения данных о слотах с ссылкой на дисциплину (с пагинацией)
    //метод для получения данных о слоте по id с ссылкой на на дисциплину
}

