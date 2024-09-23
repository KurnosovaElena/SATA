namespace AssemblyService.DataAccess.Entities;

public class Detail
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<Subject>? Subjects { get; set; }

    public ICollection<Classroom>? Classrooms { get; set; }
}