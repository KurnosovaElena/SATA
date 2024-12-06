using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.BusinessLogic.Services.Interfaces;
public interface ITimetableService
{
    Task<IEnumerable<CompletedSlotModel>> GenerateTimeTableForDepartmentGroupsAsync(Guid departmentId, int workingDaysCount = 5, CancellationToken cancellationToken = default);

}
