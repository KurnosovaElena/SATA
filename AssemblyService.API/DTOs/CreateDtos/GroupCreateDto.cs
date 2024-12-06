namespace AssemblyService.API.DTOs.CreateDtos;

public record GroupCreateDto(
    string Name,
    DateOnly StartYear,
    DateOnly EndYear,
    int Course,
    int StudentCount,
    int IdentityNumber,
    Guid DepartmentId,
    ICollection<SubgroupDto>? Subgroups
    );
