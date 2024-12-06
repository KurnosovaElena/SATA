namespace AssemblyService.API.DTOs.CreateDtos;

public record SubgroupCreateDto(
    Guid GroupId,
    IEnumerable<SubjectDto> Subjects
    );