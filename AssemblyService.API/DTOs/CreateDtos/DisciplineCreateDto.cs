namespace AssemblyService.API.DTOs.CreateDtos;

public record DisciplineCreateDto(string Name, string? ShortName, Guid DepartmentId);