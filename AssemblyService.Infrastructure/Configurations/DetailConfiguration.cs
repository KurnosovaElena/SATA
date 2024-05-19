using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasMany(d => d.Subjects)
                .WithMany(t => t.Details);

            builder
                .HasMany(d => d.Classrooms)
                .WithMany(t => t.Details);

            builder
                .ToTable("detail");
        }
    }
}