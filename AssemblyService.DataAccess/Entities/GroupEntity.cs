namespace AssemblyService.DataAccess.Entities;

public class GroupEntity
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    public DateOnly StartYear { get; set; }
    public DateOnly EndYear { get; set; }
    public int Course { get; set; }
    public int StudentCount { get; set; }
    public int IdentityNumber { get; set; }

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    //Lazy loading
    public virtual ICollection<Subgroup> Subgroups { get; set; } = [];
}
