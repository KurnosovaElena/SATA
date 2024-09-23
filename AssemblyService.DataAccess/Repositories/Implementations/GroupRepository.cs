using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Repositories.Interfaces;
using System.Text.RegularExpressions;

namespace AssemblyService.DataAccess.Repositories.Implementations;

public class GroupRepository(TimetableContext context) : RepositoryBase<Group>(context), IGroupRepository
{
}
