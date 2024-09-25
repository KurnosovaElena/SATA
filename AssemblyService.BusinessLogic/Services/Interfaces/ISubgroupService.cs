using AssemblyService.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.BusinessLogic.Services.Interfaces;

public interface ISubgroupService
{
    Task<SubgroupModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
