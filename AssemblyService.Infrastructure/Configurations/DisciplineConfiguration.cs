using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class DisciplineConfiguration : IEntityTypeConfiguration<Discipline>
    {
        public void Configure(EntityTypeBuilder<Discipline> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(d => d.Department)
                .WithMany(d => d.Disciplines);

            builder
                .ToTable("discipline");
        }
    }
}