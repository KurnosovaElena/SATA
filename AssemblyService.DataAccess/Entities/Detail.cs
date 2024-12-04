namespace AssemblyService.DataAccess.Entities;

public class Detail
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Subject>? Subjects { get; set; }

    public virtual ICollection<Classroom>? Classrooms { get; set; }
}