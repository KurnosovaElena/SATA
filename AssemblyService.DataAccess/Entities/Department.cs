namespace AssemblyService.DataAccess.Entities;

public class Department
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public Guid CampusId { get; set; }
    public Campus Campus { get; set; } = null!;

    public ICollection<Teacher>? Teachers { get; set; }

    public ICollection<Discipline>? Disciplines { get; set; }

    public ICollection<Group>? Groups { get; set; }
}