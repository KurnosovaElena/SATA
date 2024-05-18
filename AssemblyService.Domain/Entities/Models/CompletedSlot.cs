using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Domain.Entities.Models
{
    internal class CompletedSlot
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int ClassroomId { get; set; }
        public string DayName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public byte[] WeekType { get; set; }

        public Subject Subject { get; set; } // Navigation property
        public Classroom Classroom { get; set; } 
    }
}
