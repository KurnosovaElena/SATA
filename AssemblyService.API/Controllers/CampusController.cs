using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Implementations;
using Microsoft.AspNetCore.Mvc;
using Mapster;
using AssemblyService.BusinessLogic.Services.Interfaces;
namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class CampusController(ICampusService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<CampusDto>> GetAll(CancellationToken cancellationToken)
    {
        var Campuss = await service.GetAllAsync(cancellationToken);

        var CampussDto = Campuss.Adapt<IEnumerable<CampusDto>>();
        return CampussDto;
    }

    [HttpGet("{id}")]
    public async Task<CampusDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var Campuss = await service.GetByIdAsync(id, cancellationToken);

        var CampussDto = Campuss.Adapt<CampusDto>();

        return CampussDto;
    }

    [HttpPost]
    public async Task<CampusDto> Add([FromBody] CampusCreateDto createDto, CancellationToken cancellationToken)
    {
        var Campus = createDto.Adapt<CampusModel>();

        var CampusToReturn = await service.AddAsync(Campus, cancellationToken);

        return CampusToReturn.Adapt<CampusDto>();
    }

    [HttpPut("{id}")]
    public async Task<CampusDto> Update([FromRoute] Guid id, [FromBody] CampusCreateDto createDto, CancellationToken cancellationToken)
    {
        var Campus = createDto.Adapt<CampusModel>();

        Campus.Id = id;

        var modelToRerturn = await service.UpdateAsync(Campus, cancellationToken);

        return modelToRerturn.Adapt<CampusDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await service.DeleteAsync(id, cancellationToken);

}
