using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyService.Domain.Entities.Models;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class SubgroupConfiguration : IEntityTypeConfiguration<Subgroup>
    {
        public void Configure(EntityTypeBuilder<Subgroup> builder)
        {
            builder
                .HasKey(x => x.GroupId);

            builder
                .HasOne(sg => sg.Group)
                .WithMany(g => g.Subgroups);

            builder
                .HasMany(sg => sg.CompletedSlots)
                .WithMany(cs => cs.Subgroups);

            builder
                .ToTable("subgroup");
        }
    }
}