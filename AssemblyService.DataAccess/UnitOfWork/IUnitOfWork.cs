using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Interfaces;

namespace AssemblyService.DataAccess.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Campus> Campus { get; }
    IClassroomRepository Classroom { get; }
    ICompletedSlotRepository CompletedSlot { get; }
    IDepartmentRepository Department { get; }
    IGenericRepository<Detail> Detail { get; }
    IDisciplineRepository Discipline { get; }
    IGroupRepository Group { get; }
    IGenericRepository<Subgroup> Subgroup { get; }
    IGenericRepository<Subject> Subject { get; }
    IGenericRepository<SubjectType> SubjectType { get; }
    ITeacherRepository Teacher { get; }

    Task SaveChangesAsync(CancellationToken cancellationToken);
}
