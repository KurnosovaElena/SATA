using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using Mapster;
using AssemblyService.BusinessLogic.Services.Interfaces;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DisciplineController(IDisciplineService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<DisciplineDto>> GetAll(CancellationToken cancellationToken)
    {
        var Disciplines = await service.GetAllAsync(cancellationToken);

        var DisciplinesDto = Disciplines.Adapt<IEnumerable<DisciplineDto>>();
        return DisciplinesDto;
    }

    [HttpGet("{id}")]
    public async Task<DisciplineDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var Disciplines = await service.GetByIdAsync(id, cancellationToken);

        var DisciplinesDto = Disciplines.Adapt<DisciplineDto>();

        return DisciplinesDto;
    }

    [HttpPost]
    public async Task<DisciplineDto> Add([FromBody] DisciplineCreateDto createDto, CancellationToken cancellationToken)
    {
        var Discipline = createDto.Adapt<DisciplineModel>();

        var DisciplineToReturn = await service.AddAsync(Discipline, cancellationToken);

        return DisciplineToReturn.Adapt<DisciplineDto>();
    }

    [HttpPut("{id}")]
    public async Task<DisciplineDto> Update([FromRoute] Guid id, [FromBody] DisciplineCreateDto createDto, CancellationToken cancellationToken)
    {
        var Discipline = createDto.Adapt<DisciplineModel>();

        Discipline.Id = id;

        var modelToRerturn = await service.UpdateAsync(Discipline, cancellationToken);

        return modelToRerturn.Adapt<DisciplineDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await service.DeleteAsync(id, cancellationToken);
}
