namespace AssemblyService.API.DTOs.CreateDtos;

public record DepartmentCreateDto(
        string Name,
        Guid CampusId
    );
