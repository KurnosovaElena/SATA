using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Enums;
using Bogus;

namespace AssemblyService.DataAccess.Context;

/// <summary>
/// Test data seeder
/// </summary>
/// <param name="builder"></param>
public class DataGenerator
{
    public List<Campus> Campuses { get; set; } = [];
    public List<Classroom> Classrooms { get; set; } = [];
    public List<CompletedSlot> CompletedSlots { get; set; } = [];
    public List<Department> Departments { get; set; } = [];
    public List<Detail> Details { get; set; } = [];
    public List<Discipline> Disciplines { get; set; } = [];
    public List<GroupEntity> GroupEntities { get; set; } = [];
    public List<Subgroup> Subgroups { get; set; } = [];
    public List<Subject> Subjects { get; set; } = [];
    public List<SubjectType> SubjectTypes { get; set; } = [];
    public List<Teacher> Teachers { get; set; } = [];

    public void Init()
    {
        GenerateCampuses();
        GenerateTeachers();
    }

    public List<Campus> GenerateCampuses()
    {

        var campuses = new Faker<Campus>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.Number, f => f.Random.Number(1, 100))
            .RuleFor(c => c.Coordinates, f => f.Address.Latitude() + ", " + f.Address.Longitude())
            .Generate(5); // Generate 5 campuses

        Campuses.AddRange(campuses);

        // Generate classrooms for each campus
        foreach (var campus in campuses)
        {
            GenerateClassrooms(campus.Id, 5);
            GenerateDepartments(campus.Id, 5);
        }

        return campuses;
    }

    public List<Classroom> GenerateClassrooms(Guid campusId, int number)
    {
        var classroomFaker = new Faker<Classroom>()
            .RuleFor(c => c.Id, f => Guid.NewGuid())
            .RuleFor(c => c.Number, f => f.Random.Number(101, 999))
            .RuleFor(c => c.Capacity, f => f.Random.Number(20, 100))
            .RuleFor(c => c.CampusId, campusId)
            .Generate(number); // Generate `number` classrooms for the campus
        Classrooms.AddRange(classroomFaker);

        return classroomFaker;
    }

    public List<Department> GenerateDepartments(Guid campusId, int number)
    {
        var departmentFaker = new Faker<Department>()
            .RuleFor(d => d.Id, f => Guid.NewGuid())
            .RuleFor(d => d.Name, f => f.Commerce.Department())
            .RuleFor(d => d.CampusId, campusId)
            .Generate(number); // Generate `number` departments for the campus
        Departments.AddRange(departmentFaker);

        // Generate teachers, disciplines, and groups for each department
        foreach (var department in departmentFaker)
        {
            GenerateDisciplines(department.Id, 3);
            GenerateGroups(department.Id, 3);
        }
        return departmentFaker;
    }

    public List<Teacher> GenerateTeachers()
    {
        var teacherFaker = new Faker<Teacher>()
            .RuleFor(t => t.Id, f => Guid.NewGuid())
            .RuleFor(t => t.FirstName, f => f.Name.FirstName())
            .RuleFor(t => t.LastName, f => f.Name.LastName())
            .RuleFor(t => t.Position, f => f.Name.JobTitle())
            .Generate(5); // Generate `number` teachers
        Teachers.AddRange(teacherFaker);

        return teacherFaker;
    }

    public List<Subject> GenerateSubjects(int number, Guid teacherId, Guid disciplineId, Guid subjectTypeId)
    {
        var subjectFaker = new Faker<Subject>()
            .RuleFor(s => s.Id, f => Guid.NewGuid())
            .RuleFor(s => s.TeacherId, teacherId)
            .RuleFor(s => s.DisciplineId, disciplineId)
            .RuleFor(s => s.RequestedHoursPerWeek, f => f.Random.Number(1, 5))
            .RuleFor(s => s.SubjectTypeId, subjectTypeId)
            .Generate(number);
        Subjects.AddRange(subjectFaker);
        return subjectFaker;
    }

    public List<Discipline> GenerateDisciplines(Guid departmentId, int number)
    {
        var disciplineFaker = new Faker<Discipline>()
            .RuleFor(d => d.Id, f => Guid.NewGuid())
            .RuleFor(d => d.Name, f => f.Commerce.ProductName())
            .RuleFor(d => d.ShortName, f => f.Lorem.Word())
            .RuleFor(d => d.DepartmentId, departmentId)
            .Generate(number);

        Disciplines.AddRange(disciplineFaker);
        return disciplineFaker;
    }

    public List<GroupEntity> GenerateGroups(Guid departmentId, int number)
    {
        var groupFaker = new Faker<GroupEntity>()
            .RuleFor(g => g.Id, f => Guid.NewGuid())
            .RuleFor(g => g.Name, f => f.Commerce.Department())
            .RuleFor(g => g.StartYear, f => f.Date.PastDateOnly(4))
            .RuleFor(g => g.EndYear, f => f.Date.FutureDateOnly(4))
            .RuleFor(g => g.Course, f => f.Random.Number(1, 4))
            .RuleFor(g => g.StudentCount, f => f.Random.Number(10, 50))
            .RuleFor(g => g.IdentityNumber, f => f.Random.Number(1000, 9999))
            .RuleFor(g => g.DepartmentId, departmentId)
            .Generate(number);

        GroupEntities.AddRange(groupFaker);
        return groupFaker;
    }


}
