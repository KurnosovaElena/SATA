using NodaTime;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyService.Domain.Entities.Models
{
    public class Group
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public LocalDate StartYear { get; set; }
        public LocalDate EndYear { get; set; }
        public int Course { get; set; }
        public int StudentCount { get; set; }
        public int IdentityNumber { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;

        public ICollection<Subgroup> Subgroups { get; set; } = [];
    }
}