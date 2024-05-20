namespace AssemblyService.Domain.Entities.Models
{
    public class Subgroup
    {
        public int SubgroupId { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; } = null!;

        public ICollection<Subject>? Subjects { get; set; }
    }
}