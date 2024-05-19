using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(d => d.Department)
                .WithMany(d => d.Groups);

            builder
                .HasMany(g => g.Subgroups)
                .WithOne(sg => sg.Group);

            builder
                .ToTable("group");
        }
    }
}