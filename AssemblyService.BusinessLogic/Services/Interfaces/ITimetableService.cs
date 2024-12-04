using AssemblyService.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.BusinessLogic.Services.Interfaces;
public interface ITimetableService
{
    Task<IEnumerable<CompletedSlotModel>> GenerateTimeTableForDepartmentGroupsAsync(Guid departmentId, int workingDaysCount = 5, CancellationToken cancellationToken = default);

}
