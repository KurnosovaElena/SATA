using AssemblyService.DataAccess.Enums;

namespace AssemblyService.API.DTOs.CreateDtos;

public record CompletedSlotCreateDto(
    DayOfWeek DayOfWeek,
    TimeSlot TimeSlot,
    WeekType WeekType,
    Guid SubjectId,
    Guid ClassroomId
);