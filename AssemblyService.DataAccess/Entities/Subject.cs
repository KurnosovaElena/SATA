namespace AssemblyService.DataAccess.Entities;

public class Subject
{
    public Guid Id { get; set; }

    public Guid TeacherId { get; set; }
    public virtual Teacher Teacher { get; set; } = null!;

    public Guid DisciplineId { get; set; }
    public virtual Discipline Discipline { get; set; } = null!;

    public int RequestedHoursPerWeek { get; set; }

    public Guid SubjectTypeId { get; set; }
    public virtual SubjectType SubjectType { get; set; } = null!;

    public virtual ICollection<Detail>? Details { get; set; }
    public virtual ICollection<Subgroup>? Subgroups { get; set; }

    //Lazy
    public virtual ICollection<CompletedSlot>? CompletedSlots { get; set; }

    //Recommended classrooms
    public virtual ICollection<Classroom>? Classrooms { get; set; }
}