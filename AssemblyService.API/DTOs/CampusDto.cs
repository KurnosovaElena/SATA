using AssemblyService.API.DTOs.CreateDtos;

namespace AssemblyService.API.DTOs;

public record CampusDto(
    Guid Id,
    int Number,
    string? Coordinates,
    IEnumerable<ClassroomDto> Classrooms,
    IEnumerable<DepartmentDto> Departments
    );