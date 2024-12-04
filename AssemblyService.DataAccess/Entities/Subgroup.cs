namespace AssemblyService.DataAccess.Entities;

public class Subgroup
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }
    public virtual GroupEntity Group { get; set; } = null!;
 
    public virtual ICollection<Subject>? Subjects { get; set; }
}
