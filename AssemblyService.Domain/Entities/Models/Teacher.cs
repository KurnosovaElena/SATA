using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyService.Domain.Entities.Models
{
    public class Teacher
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Position { get; set; } = null!;

        public ICollection<Department> Departments { get; set; } = null!;

        public ICollection<Subject>? Subjects { get; set; }
    }
}