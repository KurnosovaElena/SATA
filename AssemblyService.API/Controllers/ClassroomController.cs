using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassroomController(IClassroomService service)
{
    [HttpGet]
    public async Task<IEnumerable<ClassroomDto>> GetAll(CancellationToken cancellationToken)
    {
        var Classrooms = await service.GetAllAsync(cancellationToken);

        var ClassroomsDto = Classrooms.Adapt<IEnumerable<ClassroomDto>>();
        return ClassroomsDto;
    }

    [HttpGet("{id}")]
    public async Task<ClassroomDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var Classrooms = await service.GetByIdAsync(id, cancellationToken);

        var ClassroomsDto = Classrooms.Adapt<ClassroomDto>();

        return ClassroomsDto;
    }

    [HttpPost]
    public async Task<ClassroomDto> Add([FromBody] ClassroomCreateDto createDto, CancellationToken cancellationToken)
    {
        var Classroom = createDto.Adapt<ClassroomModel>();

        var ClassroomToReturn = await service.AddAsync(Classroom, cancellationToken);

        return ClassroomToReturn.Adapt<ClassroomDto>();
    }

    [HttpPut("{id}")]
    public async Task<ClassroomDto> Update([FromRoute] Guid id, [FromBody] ClassroomCreateDto createDto, CancellationToken cancellationToken)
    {
        var Classroom = createDto.Adapt<ClassroomModel>();

        Classroom.Id = id;

        var modelToRerturn = await service.UpdateAsync(Classroom, cancellationToken);

        return modelToRerturn.Adapt<ClassroomDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await service.DeleteAsync(id, cancellationToken);


}
