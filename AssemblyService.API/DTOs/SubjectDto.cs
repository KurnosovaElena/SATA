namespace AssemblyService.API.DTOs;

public record SubjectDto(
    Guid Id,
    TeacherDto Teacher,
    DisciplineDto Discipline,
    int RequestedHoursPerWeek,
    SubjectTypeDto SubjectType,
    IEnumerable<DetailDto> Details,
    IEnumerable<SubgroupDto> Subgroups,
    IEnumerable<CompletedSlotDto> CompletedSlots,
    IEnumerable<ClassroomDto> Classrooms
    );
