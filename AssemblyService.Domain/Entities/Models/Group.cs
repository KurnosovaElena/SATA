using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Domain.Entities.Models
{
    internal class Group
    {
        [Key]
        public int Id { get; set; }
        
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        
        public string Name { get; set; }
        public DateTime StartYear { get; set; }
        public DateTime EndYear { get; set; }
        public int Course { get; set; }
        public int IdentityNumber { get; set; }
    }
}
