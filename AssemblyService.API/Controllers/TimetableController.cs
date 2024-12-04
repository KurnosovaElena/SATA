using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TimetableController(ITimetableService service) : ControllerBase
{

    public async Task<IEnumerable<CompletedSlotDto>> GenerateSlotsForDepartment([FromRoute] Guid departmentId, CancellationToken cancellationToken)
    {
        var slots = service.GenerateTimeTableForDepartmentGroupsAsync(departmentId, cancellationToken: cancellationToken);

        var slotsDto = slots.Adapt<IEnumerable<CompletedSlotDto>>();

        return slotsDto;
    }
}