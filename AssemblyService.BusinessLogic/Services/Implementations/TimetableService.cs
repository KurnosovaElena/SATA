using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.UnitOfWork;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class TimetableService(IUnitOfWork unitOfWork, IDepartmentService departmentService)
{
    public async Task<IEnumerable<CompletedSlotModel>> GenerateTimeTableForDepartmentGroupsAsync(Guid departmentId, bool clearExistingSlots, CancellationToken cancellationToken)
    {
        var department = await departmentService.GetByIdAsync(departmentId, cancellationToken);

        if (department.Groups is null || department.Groups.Count == 0)
        {
            throw new BadRequestException(DepartmentExceptionMessages.GroupsIsNullOrEmpty(departmentId));
        }

        var groups = department.Groups.OrderBy(g => g.Course).OrderBy(g => g.Name);

        foreach (var group in groups)
        {
            if(group.Subgroups is null || group.Subgroups.Count == 0)
            {
                throw new BadRequestException(DepartmentExceptionMessages.SubgroupsIsNullOrEmpty(group.Id));
            }

            foreach(var subgroup in group.Subgroups)
            {
                //TODO get subjects by subgroup id

                //TODO
                //generate empty slots
                //if clearExistingSlots is true, delete slots
                //if not, substract expected time from subjects by existing slots and make a gap in at least one day for next similar subject
                //if slot is free, get teacher by id from subject
                //if teacher slot is busy, move to other slot until true
                //use slot by pattern: 1. full week, 2. upper week, 3. lower week
                //if subject cannot be performed in full week, use either upper or lower
                //if teacher slot is free, get recommended classrooms
                //if recommended classromms are busy, move to all classrooms that are satisfy subject details
                //firstly search in current campus, then in campuses nearby(if 2, then 4 and 7)         (HOW TO DO THAT)
            }
        }
    }
}
