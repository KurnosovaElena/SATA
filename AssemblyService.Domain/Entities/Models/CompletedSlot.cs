using AssemblyService.Domain.Entities.Enums;
using NodaTime;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssemblyService.Domain.Entities.Models
{
    public class CompletedSlot
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DayOfWeek DayName { get; set; }
        public Period Start { get; set; }
        public Period End { get; set; }

        public WeekType WeekType { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; } = null!;

        public int ClassroomId { get; set; }
        public Classroom Classroom { get; set; } = null!;

        public ICollection<Subgroup> Subgroups { get; set; } = [];
    }
}