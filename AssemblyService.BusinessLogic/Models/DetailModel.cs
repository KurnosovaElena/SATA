namespace AssemblyService.BusinessLogic.Models;

public class DetailModel
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;

    public ICollection<SubjectModel>? Subjects { get; set; }
    public ICollection<ClassroomModel>? Classrooms { get; set; }
}