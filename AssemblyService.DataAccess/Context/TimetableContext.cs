using AssemblyService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AssemblyService.DataAccess.Context;

public class TimetableContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Campus> Campuses { get; set; }
    public DbSet<Classroom> Classrooms { get; set; }
    public DbSet<CompletedSlot> CompletedSlots { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Detail> Details { get; set; }
    public DbSet<Discipline> Disciplines { get; set; }
    public DbSet<GroupEntity> Groups { get; set; }
    public DbSet<Subgroup> Subgroups { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<SubjectType> SubjectTypes { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        new Seed(modelBuilder).SeedTestData();
    }
}
