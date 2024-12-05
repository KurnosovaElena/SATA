namespace AssemblyService.API.DTOs.CreateDtos;

public record TeacherCreateDto(
    string FirstName,
    string LastName,
    string Position
);