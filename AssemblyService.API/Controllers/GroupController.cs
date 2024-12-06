using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GroupController(IGroupService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<GroupDto>> GetAll(CancellationToken cancellationToken)
    {
        var Groups = await service.GetAllAsync(cancellationToken);

        var GroupsDto = Groups.Adapt<IEnumerable<GroupDto>>();
        return GroupsDto;
    }

    [HttpGet("{id}")]
    public async Task<GroupDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var Groups = await service.GetByIdAsync(id, cancellationToken);

        var GroupsDto = Groups.Adapt<GroupDto>();

        return GroupsDto;
    }

    [HttpPost]
    public async Task<GroupDto> Add([FromBody] GroupCreateDto createDto, CancellationToken cancellationToken)
    {
        var Group = createDto.Adapt<GroupModel>();

        var GroupToReturn = await service.AddAsync(Group, cancellationToken);

        return GroupToReturn.Adapt<GroupDto>();
    }

    [HttpPut("{id}")]
    public async Task<GroupDto> Update([FromRoute] Guid id, [FromBody] GroupCreateDto createDto, CancellationToken cancellationToken)
    {
        var Group = createDto.Adapt<GroupModel>();

        Group.Id = id;

        var modelToRerturn = await service.UpdateAsync(Group, cancellationToken);

        return modelToRerturn.Adapt<GroupDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await service.DeleteAsync(id, cancellationToken);

}
