using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Domain.Entities.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }


        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; } = null!;

        public int DisciplineId { get; set; }
        public Discipline Discipline { get; set; } = null!;

        public int HoursPerWeek { get; set; }

        public int SubjectTypeId { get; set; }
        public SubjectType SubjectType { get; set; } = null!;

        public ICollection<Detail>? Details { get; set; }
        public ICollection<Subgroup>? Subgroups { get; set; }
        public ICollection<CompletedSlot>? CompletedSlots { get; set; }

    }
}
