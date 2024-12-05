using AssemblyService.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.DataAccess.Context;

/// <summary>
/// EF Database Context
/// </summary>
public class TimetableContext : DbContext
{
    public TimetableContext(DbContextOptions options) : base(options)
    {
        //Add migrations on context initialization
        Database.Migrate();
    }

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

            var dg = new DataGenerator();

            dg.GenerateCampuses();
            modelBuilder.Entity<Teacher>().HasData(dg.Teachers);
            modelBuilder.Entity<Campus>().HasData(dg.Campuses);
            modelBuilder.Entity<Classroom>().HasData(dg.Classrooms);
            modelBuilder.Entity<CompletedSlot>().HasData(dg.CompletedSlots);
            modelBuilder.Entity<Department>().HasData(dg.Departments);
            modelBuilder.Entity<Detail>().HasData(dg.Details);
            modelBuilder.Entity<Discipline>().HasData(dg.Disciplines);
            modelBuilder.Entity<GroupEntity>().HasData(dg.GroupEntities);
            modelBuilder.Entity<Subgroup>().HasData(dg.Subgroups);
            modelBuilder.Entity<Subject>().HasData(dg.Subjects);
            modelBuilder.Entity<SubjectType>().HasData(dg.Subjects);
    }
}
