namespace AssemblyService.BusinessLogic.Models;

public class SubgroupModel
{
    public Guid Id { get; set; }

    public Guid GroupId { get; set; }
    public GroupModel Group { get; set; } = null!;

    public ICollection<SubjectModel>? Subjects { get; set; }
}