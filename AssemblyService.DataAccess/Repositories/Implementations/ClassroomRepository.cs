using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class ClassroomRepository(TimetableContext context) : RepositoryBase<Classroom>(context), IClassroomRepository
{
    //метод для получения данных об аудиториях с ссылкой на корпус (с пагинацией)
    //метод для получения данных об аудитории по id с ссылкой на корпус и детали об аудитории
}