namespace AssemblyService.BusinessLogic.Models;

public class SubjectModel
{
    public Guid Id { get; set; }

    public Guid TeacherId { get; set; }
    public TeacherModel Teacher { get; set; } = null!;

    public Guid DisciplineId { get; set; }
    public DisciplineModel Discipline { get; set; } = null!;

    public int RequestedHoursPerWeek { get; set; }

    public Guid SubjectTypeId { get; set; }
    public SubjectTypeModel SubjectType { get; set; } = null!;

    public ICollection<DetailModel>? Details { get; set; }
    public ICollection<SubgroupModel>? Subgroups { get; set; }
    public ICollection<CompletedSlotModel>? CompletedSlots { get; set; }
}