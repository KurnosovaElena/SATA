using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyService.Domain.Entities.Models
{
    public class Campus
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Number { get; set; }

        public string? Coordinates { get; set; }

        public ICollection<Classroom> Classrooms { get; set; } = null!;
        public ICollection<Department>? Departments { get; set; }
    }
}