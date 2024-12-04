namespace AssemblyService.DataAccess.Entities;

public class Campus
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string? Coordinates { get; set; }

    public virtual ICollection<Classroom> Classrooms { get; set; } = null!;
    public virtual ICollection<Department>? Departments { get; set; }
}