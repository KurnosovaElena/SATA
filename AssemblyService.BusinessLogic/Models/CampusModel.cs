namespace AssemblyService.BusinessLogic.Models;

public class CampusModel
{
    public Guid Id { get; set; }

    public int Number { get; set; }

    public string? Coordinates { get; set; }

    public ICollection<ClassroomModel> Classrooms { get; set; } = null!;
    public ICollection<DepartmentModel>? Departments { get; set; }
}