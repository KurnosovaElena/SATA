namespace AssemblyService.BusinessLogic.Models;

public class TeacherModel
{
    public Guid Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Position { get; set; } = null!;

    public ICollection<DepartmentModel> Departments { get; set; } = null!;
    public ICollection<SubjectModel>? Subjects { get; set; }
}