using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Infrastructure.Configurations
{
    internal class CompletedSlotConfiguration : IEntityTypeConfiguration<CompletedSlot>
    {
        public void Configure(EntityTypeBuilder<CompletedSlot> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(cs => cs.Classroom)
                .WithMany(c => c.CompletedSlots);

            builder
                .HasMany(cs => cs.Subgroups)
                .WithMany(sg => sg.CompletedSlots);

            builder
                .Property(cs => cs.WeekType)
                .HasDefaultValue(0);

            builder
                .ToTable("completed_slot");
        }
    }
}