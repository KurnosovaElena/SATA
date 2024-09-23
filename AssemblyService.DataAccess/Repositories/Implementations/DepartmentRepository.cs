using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;

namespace AssemblyService.DataAccess.Repositories.Implementations
{
    public class DepartmentRepository(TimetableContext context) : RepositoryBase<Department>(context), IDepartmentRepository
    {
    }
}