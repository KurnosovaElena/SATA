using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.BusinessLogic.Services.Implementations;
public class SubgroupService(IUnitOfWork unitOfWork) : ISubgroupService
{
    public async Task<SubgroupModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var subgroup = await unitOfWork.Subgroup.GetByIdAsync(id, cancellationToken);

        var subgroupModel = subgroup.Adapt<SubgroupModel>();

        return subgroupModel;
    }
}
