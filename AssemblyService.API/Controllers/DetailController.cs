using AssemblyService.API.DTOs;
using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;
using Microsoft.AspNetCore.Mvc;
namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class DetailController(IDetailService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<DetailDto>> GetAll(CancellationToken cancellationToken)
    {
        var Details = await service.GetAllAsync(cancellationToken);

        var DetailsDto = Details.Adapt<IEnumerable<DetailDto>>();
        return DetailsDto;
    }

    [HttpGet("{id}")]
    public async Task<DetailDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var Details = await service.GetByIdAsync(id, cancellationToken);

        var DetailsDto = Details.Adapt<DetailDto>();

        return DetailsDto;
    }

    [HttpPost]
    public async Task<DetailDto> Add([FromBody] DetailCreateDto createDto, CancellationToken cancellationToken)
    {
        var Detail = createDto.Adapt<DetailModel>();

        var DetailToReturn = await service.AddAsync(Detail, cancellationToken);

        return DetailToReturn.Adapt<DetailDto>();
    }

    [HttpPut("{id}")]
    public async Task<DetailDto> Update([FromRoute] Guid id, [FromBody] DetailCreateDto createDto, CancellationToken cancellationToken)
    {
        var Detail = createDto.Adapt<DetailModel>();

        Detail.Id = id;

        var modelToRerturn = await service.UpdateAsync(Detail, cancellationToken);

        return modelToRerturn.Adapt<DetailDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await service.DeleteAsync(id, cancellationToken);

}
