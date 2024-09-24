using AssemblyService.DataAccess.Enums;

namespace AssemblyService.BusinessLogic.Models;

public class CompletedSlotModel
{
    public Guid Id { get; set; }

    //Params to arrange subject by slots
    public DayOfWeek DayOfWeek { get; set; }
    public TimeSlot TimeSlot { get; set; }
    public WeekType WeekType { get; set; }

    public Guid SubjectId { get; set; }
    public SubjectModel Subject { get; set; } = null!;

    public Guid ClassroomId { get; set; }
    public ClassroomModel Classroom { get; set; } = null!;
}