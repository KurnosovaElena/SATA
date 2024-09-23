namespace AssemblyService.DataAccess.Entities;

public class Subgroup
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }
    public Group Group { get; set; } = null!;

    public ICollection<Subject>? Subjects { get; set; }
}
