using AssemblyService.API.DTOs;
using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.BusinessLogic.Models;
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
    public async Task<DepartmentDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var departments = await departmentService.GetByIdAsync(id, cancellationToken);

        var departmentsDto = departments.Adapt<DepartmentDto>();

        return departmentsDto;
    }

    [HttpPost]
    public async Task<DepartmentDto> Add([FromBody] DepartmentCreateDto createDto, CancellationToken cancellationToken)
    {
        var department = createDto.Adapt<DepartmentModel>();

        var departmentToReturn = await departmentService.AddAsync(department, cancellationToken);

        return departmentToReturn.Adapt<DepartmentDto>();
    }

    [HttpPut("{id}")]
    public async Task<DepartmentDto> Update([FromRoute] Guid id, [FromBody] DepartmentCreateDto createDto, CancellationToken cancellationToken)
    {
        var department = createDto.Adapt<DepartmentModel>();

        department.Id = id;

        var modelToRerturn = await departmentService.UpdateAsync(department, cancellationToken);

        return modelToRerturn.Adapt<DepartmentDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await departmentService.DeleteAsync(id, cancellationToken);
}
