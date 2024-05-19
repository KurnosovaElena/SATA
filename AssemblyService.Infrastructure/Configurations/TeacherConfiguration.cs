using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasMany(t => t.Departments)
                .WithMany(d => d.Teachers);

            builder
                .HasMany(t => t.Departments)
                .WithMany(d => d.Teachers);

            builder
                .ToTable("subject_type");
        }
    }
}