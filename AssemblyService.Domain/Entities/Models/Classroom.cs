using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyService.Domain.Entities.Models
{
    public class Classroom
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int Capacity { get; set; }

        public int CampusId { get; set; }
        public Campus Campus { get; set; } = null!;

        public int SubjectTypeId { get; set; }
        public SubjectType? SubjectType { get; set; }

        public ICollection<Detail>? Details { get; set; }

        public ICollection<CompletedSlot>? CompletedSlots { get; set; }
    }
}