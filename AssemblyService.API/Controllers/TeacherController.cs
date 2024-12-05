using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TeacherController(ITeacherService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<TeacherDto>> GetAll(CancellationToken cancellationToken)
    {
        var departments = await service.GetAllAsync(cancellationToken);

        var departmentsDto = departments.Adapt<IEnumerable<TeacherDto>>();

        return departmentsDto;
    }
}
