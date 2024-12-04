using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.API.DTOs;

public record TeacherDto(
    Guid Id,
    string FirstName,
    string LastName,
    string Position,
    ICollection<DepartmentDto> Departments,
    ICollection<SubjectDto>? Subjects
    );
                                                                    