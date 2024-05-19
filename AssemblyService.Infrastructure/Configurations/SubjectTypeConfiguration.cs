using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class SubjectTypeConfiguration : IEntityTypeConfiguration<SubjectType>
    {
        public void Configure(EntityTypeBuilder<SubjectType> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasMany(st => st.Classrooms)
                .WithOne(c => c.SubjectType);

            builder
                .ToTable("subject_type");
        }
    }
}