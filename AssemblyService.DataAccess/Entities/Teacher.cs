namespace AssemblyService.DataAccess.Entities;

public class Teacher
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Position { get; set; } = null!;

    public virtual ICollection<Department> Departments { get; set; } = null!;

    public virtual ICollection<Subject>? Subjects { get; set; }
}