using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class SubjectConfiguration : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(s => s.Teacher)
                .WithMany(g => g.Subjects);

            builder
                .HasMany(s => s.Details)
                .WithMany(d => d.Subjects);

            builder
                .ToTable("subject");
        }
    }
}