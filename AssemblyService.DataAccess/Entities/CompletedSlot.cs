using AssemblyService.DataAccess.Enums;

namespace AssemblyService.DataAccess.Entities;

public class CompletedSlot
{
    public Guid Id { get; set; }

    //Params to arrange subject by slots
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSlot TimeSlot { get; set; }
    public WeekType WeekType { get; set; }

    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; } = null!;

    public Guid ClassroomId { get; set; }
    public Classroom Classroom { get; set; } = null!;
}