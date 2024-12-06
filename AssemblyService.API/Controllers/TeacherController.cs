using AssemblyService.API.DTOs;
using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.BusinessLogic.Models;
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

    [HttpGet("{id}")]
    public async Task<TeacherDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var departments = await service.GetByIdAsync(id, cancellationToken);

        var departmentsDto = departments.Adapt<TeacherDto>();

        return departmentsDto;
    }

    [HttpPost]
    public async Task<TeacherDto> Add([FromBody] TeacherCreateDto createDto, CancellationToken cancellationToken)
    {
        var department = createDto.Adapt<TeacherModel>();

        var departmentToReturn = await service.AddAsync(department, cancellationToken);

        return departmentToReturn.Adapt<TeacherDto>();
    }

    [HttpPut("{id}")]
    public async Task<TeacherDto> Update([FromRoute] Guid id, [FromBody] DepartmentCreateDto createDto, CancellationToken cancellationToken)
    {
        var department = createDto.Adapt<TeacherModel>();

        department.Id = id;

        var modelToRerturn = await service.UpdateAsync(department, cancellationToken);

        return modelToRerturn.Adapt<TeacherDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await service.DeleteAsync(id, cancellationToken);

}
