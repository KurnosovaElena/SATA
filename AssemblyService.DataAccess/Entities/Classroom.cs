namespace AssemblyService.DataAccess.Entities;

public class Classroom
{
    public Guid Id { get; set; }

    public int Number { get; set; }
    public int Capacity { get; set; }

    public Guid CampusId { get; set; }
    public virtual Campus Campus { get; set; } = null!;

    public virtual ICollection<Detail>? Details { get; set; }

    public virtual ICollection<CompletedSlot>? CompletedSlots { get; set; }

    public virtual ICollection<Subject>? Subjects { get; set; }
}