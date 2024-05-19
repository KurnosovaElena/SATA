using AssemblyService.Domain.Entities.Models;
using AssemblyService.Domain.Interfaces.Repositories;

namespace AssemblyService.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepositoryBase<Campus> Campus { get; }
        IClassroomRepository Classroom { get; }
        ICompletedSlotRepository CompletedSlot { get; }
        IDepartmentRepository Department { get; }
        IRepositoryBase<Detail> Detail { get; }
        IDisciplineRepository Discipline { get; }
        IGroupRepository Group { get; }
        IRepositoryBase<Subgroup> Subgroup { get; }
        IRepositoryBase<Subject> Subject { get; }
        IRepositoryBase<SubjectType> SubjectType { get; }
        ITeacherRepository Teacher { get; }

        Task SaveChangesAsync(CancellationToken cancellationToken);
    }
}