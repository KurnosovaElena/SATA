namespace AssemblyService.DataAccess.Entities;

public class Subject
{
    public Guid Id { get; set; }

    public Guid TeacherId { get; set; }
    public Teacher Teacher { get; set; } = null!;

    public Guid DisciplineId { get; set; }
    public Discipline Discipline { get; set; } = null!;

    public int RequestedHoursPerWeek { get; set; }

    public Guid SubjectTypeId { get; set; }
    public SubjectType SubjectType { get; set; } = null!;

    public ICollection<Detail>? Details { get; set; }
    public ICollection<Subgroup>? Subgroups { get; set; }

    //Lazy
    public virtual ICollection<CompletedSlot>? CompletedSlots { get; set; }

    //Recommended classrooms
    public ICollection<Classroom>? Classrooms { get; set; }
}