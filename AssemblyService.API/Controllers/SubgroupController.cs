using AssemblyService.API.DTOs;
using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Implementations;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SubgroupController(ISubgroupService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<SubgroupDto>> GetAll(CancellationToken cancellationToken)
    {
        var departments = await service.GetAllAsync(cancellationToken);

        var departmentsDto = departments.Adapt<IEnumerable<SubgroupDto>>();

        return departmentsDto;
    }

    [HttpGet("{id}")]
    public async Task<SubgroupDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var departments = await service.GetByIdAsync(id, cancellationToken);

        var departmentsDto = departments.Adapt<SubgroupDto>();

        return departmentsDto;
    }

    [HttpPost]
    public async Task<SubgroupDto> Add([FromBody] SubgroupCreateDto createDto, CancellationToken cancellationToken)
    {
        var department = createDto.Adapt<SubgroupModel>();

        var departmentToReturn = await service.AddAsync(department, cancellationToken);

        return departmentToReturn.Adapt<SubgroupDto>();
    }

    [HttpPut("{id}")]
    public async Task<SubgroupDto> Update([FromRoute] Guid id, [FromBody] DepartmentCreateDto createDto, CancellationToken cancellationToken)
    {
        var department = createDto.Adapt<SubgroupModel>();

        department.Id = id;

        var modelToRerturn = await service.UpdateAsync(department, cancellationToken);

        return modelToRerturn.Adapt<SubgroupDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await service.DeleteAsync(id, cancellationToken);
}
