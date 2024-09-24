namespace AssemblyService.BusinessLogic.Models;

public class DisciplineModel
{
    public Guid Id { get; set; }

    public string Name { get; set; } = null!;
    public string? ShortName { get; set; }

    public Guid DepartmentId { get; set; }
    public DepartmentModel Department { get; set; } = null!;
}