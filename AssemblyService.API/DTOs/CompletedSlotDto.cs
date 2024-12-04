using AssemblyService.DataAccess.Enums;

namespace AssemblyService.API.DTOs;

public record CompletedSlotDto(
    Guid Id,
    DayOfWeek DayOfWeek,
    TimeSlot TimeSlot,
    WeekType WeekType,
    SubjectDto Subject,
    ClassroomDto Classroom
    );

                                
                               