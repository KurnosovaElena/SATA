using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TimetableController(ITimetableService service) : ControllerBase
{
    [HttpGet("{departmentId}")]
    [Authorize("update:timetable")]
    public async Task<IEnumerable<CompletedSlotDto>> GenerateSlotsForDepartment([FromRoute] Guid departmentId, CancellationToken cancellationToken)
    {
        var slots = await service.GenerateTimeTableForDepartmentGroupsAsync(departmentId, cancellationToken: cancellationToken);

        var slotsDto = slots.Adapt<IEnumerable<CompletedSlotDto>>();

        return slotsDto;
    }
}