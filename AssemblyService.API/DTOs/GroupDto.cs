using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.API.DTOs;

public record GroupDto(
    Guid Id,
    string Name,
    DateOnly StartYear,
    DateOnly EndYear,
    int Course,
    int StudentCount,
    int IdentityNumber,
    DepartmentDto Department,
    ICollection<SubgroupDto>? Subgroups
    );