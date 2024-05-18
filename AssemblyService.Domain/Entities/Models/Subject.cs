using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Domain.Entities.Models
{
    internal class Subject
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int DisciplineId { get; set; }
        public int SubjectTypeId { get; set; }
        public int DetailSubjectId { get; set; }
    }
}
