using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class ClassroomRepository(TimetableContext context) : RepositoryBase<Classroom>(context), IClassroomRepository
{
}