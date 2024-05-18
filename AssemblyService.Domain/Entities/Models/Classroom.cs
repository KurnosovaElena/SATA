using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Domain.Entities.Models
{
    internal class Classroom
    {
        public int Id { get; set; }
        public int CampusId { get; set; }
        public int SubjectTypeId { get; set; }
        public int Capacity { get; set; }
    }
}
