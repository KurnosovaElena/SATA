namespace AssemblyService.BusinessLogic.Models;

public class ClassroomModel
{
    public Guid Id { get; set; }

    public int Number { get; set; }
    public int Capacity { get; set; }

    public Guid CampusId { get; set; }
    public CampusModel Campus { get; set; } = null!;

    public ICollection<DetailModel>? Details { get; set; }
    public ICollection<CompletedSlotModel>? CompletedSlots { get; set; }
}