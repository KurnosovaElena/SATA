using AssemblyService.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Infrastructure.Context
{
    public class TimetableContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<CompletedSlot> CompletedSlots { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Discipline> Disciplines { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subgroup> Subgroups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectType> SubjectTypes { get; set; }
        public DbSet<Teacher> Teachers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UnitOfWork).Assembly);

            new Seed(modelBuilder).SeedTestData();
        }
    }
}