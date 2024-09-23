namespace AssemblyService.DataAccess.Entities;

public class Discipline
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    public string? ShortName { get; set; }

    public Guid DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
}
