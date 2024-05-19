using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>
    {
        public void Configure(EntityTypeBuilder<Classroom> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasIndex(x => new { x.Number, x.CampusId })
                .IsUnique();

            builder
                .ToTable("classroom");
        }
    }
}