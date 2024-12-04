using AssemblyService.BusinessLogic.Models;

namespace AssemblyService.API.DTOs;

public record DepartmentDto(
    Guid Id,
    string Name,
    CampusModel Campus,
    ICollection<TeacherModel>? Teachers,
    ICollection<DisciplineModel>? Disciplines,
    ICollection<GroupModel>? Groups
    );