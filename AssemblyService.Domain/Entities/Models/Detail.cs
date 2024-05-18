using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyService.Domain.Entities.Models
{
    public class Detail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public ICollection<Subject>? Subjects { get; set; }

        public ICollection<Classroom>? Classrooms { get; set; }
    }
}