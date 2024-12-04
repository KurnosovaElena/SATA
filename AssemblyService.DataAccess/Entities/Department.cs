namespace AssemblyService.DataAccess.Entities;

public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public Guid CampusId { get; set; }
    public virtual Campus Campus { get; set; } = null!;

    public virtual ICollection<Teacher>? Teachers { get; set; }

    public virtual ICollection<Discipline>? Disciplines { get; set; }

    public virtual ICollection<GroupEntity>? Groups { get; set; }
}