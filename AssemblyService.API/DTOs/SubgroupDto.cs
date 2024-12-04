using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.API.DTOs;

public record SubgroupDto(
    Guid Id,
    GroupDto Group,
    ICollection<SubjectDto>? Subjects
    );
