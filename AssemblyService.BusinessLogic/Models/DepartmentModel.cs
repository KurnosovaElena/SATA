namespace AssemblyService.BusinessLogic.Models;

public class DepartmentModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = null!;

    public CampusModel Campus { get; set; } = null!;

    public ICollection<TeacherModel>? Teachers { get; set; }
    public ICollection<DisciplineModel>? Disciplines { get; set; }
    public ICollection<GroupModel>? Groups { get; set; }
}