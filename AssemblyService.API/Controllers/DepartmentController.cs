using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DepartmentController(IDepartmentService departmentService) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<DepartmentDto>> GetAll(CancellationToken cancellationToken)
    {
        var departments = await departmentService.GetAllAsync(cancellationToken);

        var departmentsDto = departments.Adapt<IEnumerable<DepartmentDto>>();

        return departmentsDto;
    }

    [HttpGet("{id}")]
    public async Task<IEnumerable<DepartmentDto>> GetById([FromRoute]Guid id ,CancellationToken cancellationToken)
    {
        var departments = await departmentService.GetAllAsync(cancellationToken);

        var departmentsDto = departments.Adapt<IEnumerable<DepartmentDto>>();

        return departmentsDto;
    }
}
