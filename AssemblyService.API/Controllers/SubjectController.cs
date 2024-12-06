using AssemblyService.API.DTOs.CreateDtos;
using AssemblyService.API.DTOs;
using AssemblyService.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;

namespace AssemblyService.API.Controllers;

[ApiController]
[Route("[controller]")]
public class SubjectController(ISubjectService service) : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<SubjectDto>> GetAll(CancellationToken cancellationToken)
    {
        var Subjects = await service.GetAllAsync(cancellationToken);

        var SubjectsDto = Subjects.Adapt<IEnumerable<SubjectDto>>();
        return SubjectsDto;
    }

    [HttpGet("{id}")]
    public async Task<SubjectDto> GetById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var Subjects = await service.GetByIdAsync(id, cancellationToken);

        var SubjectsDto = Subjects.Adapt<SubjectDto>();

        return SubjectsDto;
    }

    [HttpPost]
    public async Task<SubjectDto> Add([FromBody] SubjectCreateDto createDto, CancellationToken cancellationToken)
    {
        var Subject = createDto.Adapt<SubjectModel>();

        var SubjectToReturn = await service.AddAsync(Subject, cancellationToken);

        return SubjectToReturn.Adapt<SubjectDto>();
    }

    [HttpPut("{id}")]
    public async Task<SubjectDto> Update([FromRoute] Guid id, [FromBody] SubjectCreateDto createDto, CancellationToken cancellationToken)
    {
        var Subject = createDto.Adapt<SubjectModel>();

        Subject.Id = id;

        var modelToRerturn = await service.UpdateAsync(Subject, cancellationToken);

        return modelToRerturn.Adapt<SubjectDto>();
    }

    [HttpDelete("{id}")]
    public async Task Delete([FromRoute] Guid id, CancellationToken cancellationToken) =>
        await service.DeleteAsync(id, cancellationToken);
}
