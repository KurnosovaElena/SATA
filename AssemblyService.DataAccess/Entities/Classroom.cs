namespace AssemblyService.DataAccess.Entities;

public class Classroom
{
    public Guid Id { get; set; }

    public int Number { get; set; }
    public int Capacity { get; set; }

    public Guid CampusId { get; set; }
    public Campus Campus { get; set; } = null!;

    public ICollection<Detail>? Details { get; set; }

    public ICollection<CompletedSlot>? CompletedSlots { get; set; }
}