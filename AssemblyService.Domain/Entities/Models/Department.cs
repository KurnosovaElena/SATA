using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyService.Domain.Entities.Models
{
    public class Department
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Teacher>? Teachers { get; set; }

        public ICollection<Discipline>? Disciplines { get; set; }

        public ICollection<Group>? Groups { get; set; }
    }
}