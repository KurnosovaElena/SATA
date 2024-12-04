namespace AssemblyService.API.DTOs;

public record DetailDto(
    Guid Id,
    string Name,
    IEnumerable<SubjectDto>? Subjects,
    IEnumerable<ClassroomDto>? Classrooms
    );