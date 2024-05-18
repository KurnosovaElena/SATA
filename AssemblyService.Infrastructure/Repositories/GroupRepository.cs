using AssemblyService.Domain.Interfaces.Repositories;
using AssemblyService.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AssemblyService.Infrastructure.Repositories
{
    public class GroupRepository(TimetableContext context) : RepositoryBase<Group>(context), IGroupRepository
    {
    }
}
