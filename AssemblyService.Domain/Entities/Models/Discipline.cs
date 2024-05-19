using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyService.Domain.Entities.Models
{
    public class Discipline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string? ShortName { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
    }
}