using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.API.DTOs;

public record DisciplineDto(
    Guid Id,
    string Name,
    string? ShortName,
    DepartmentDto Department
    );
