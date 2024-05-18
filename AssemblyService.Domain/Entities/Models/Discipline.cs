using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Domain.Entities.Models
{
    internal class Discipline
    {
        public int id { get; set; }
        public int teacher_id { get; set; }
        public string name { get; set; }
        public string short_name { get; set; }
        public int department_id { get; set; }
        public int specific_id { get; set; }
    }
}
