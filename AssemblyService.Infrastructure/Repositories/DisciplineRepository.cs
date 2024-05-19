using AssemblyService.Domain.Entities.Models;
using AssemblyService.Domain.Interfaces.Repositories;
using AssemblyService.Infrastructure.Context;

namespace AssemblyService.Infrastructure.Repositories
{
    public class DisciplineRepository(TimetableContext context) : RepositoryBase<Discipline>(context), IDisciplineRepository
    {
    }
}
