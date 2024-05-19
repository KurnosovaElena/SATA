using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class CampusConfiguration : IEntityTypeConfiguration<Campus>
    {
        public void Configure(EntityTypeBuilder<Campus> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasMany(c => c.Classrooms)
                .WithOne(cl => cl.Campus);

            builder
                .ToTable("campus");
        }
    }
}