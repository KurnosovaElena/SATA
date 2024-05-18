using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Domain.Entities.Models
{
    internal class Subgroup
    {

        [Key]
        public int Id { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }

        [Required]
        [Range(1, 999)]
        [Index(IsUnique = true)]
        public int SubgroupNumber { get; set; }

        public Group Group { get; set; }
    }
}
