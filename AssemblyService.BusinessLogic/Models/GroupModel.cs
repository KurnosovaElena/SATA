namespace AssemblyService.BusinessLogic.Models;

public class GroupModel
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    public DateOnly StartYear { get; set; }
    public DateOnly EndYear { get; set; }
    public int Course { get; set; }
    public int StudentCount { get; set; }
    public int IdentityNumber { get; set; }

    public Guid DepartmentId { get; set; }
    public DepartmentModel Department { get; set; } = null!;

    public ICollection<SubgroupModel>? Subgroups { get; set; }
}