using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.Repositories.Implementations;
using AssemblyService.DataAccess.Repositories.Interfaces;

namespace AssemblyService.DataAccess.UnitOfWork;

public class UnitOfWork(TimetableContext context) : IUnitOfWork
{
    private readonly Lazy<IGenericRepository<Campus>> _campusRepository = new(new GenericRepository<Campus>(context));
    private readonly Lazy<IClassroomRepository> _classroomRepository = new(new ClassroomRepository(context));
    private readonly Lazy<ICompletedSlotRepository> _completedSlotRepository = new(new CompletedSlotRepository(context));
    private readonly Lazy<IDepartmentRepository> _departmentRepository = new(new DepartmentRepository(context));
    private readonly Lazy<IGenericRepository<Detail>> _detailRepository = new(new GenericRepository<Detail>(context));
    private readonly Lazy<IDisciplineRepository> _disciplineRepository = new(new DisciplineRepository(context));
    private readonly Lazy<IGroupRepository> _grroupRepository = new(new GroupRepository(context));
    private readonly Lazy<ISubgroupRepository> _subgroupRepository = new(new SubgroupRepository(context));
    private readonly Lazy<IGenericRepository<Subject>> _subjectRepository = new(new GenericRepository<Subject>(context));
    private readonly Lazy<IGenericRepository<SubjectType>> _subjectTypeRepository = new(new GenericRepository<SubjectType>(context));
    private readonly Lazy<ITeacherRepository> _teacherRepository = new(new TeacherRepository(context));

    public IGenericRepository<Campus> Campus => _campusRepository.Value;
    public IClassroomRepository Classroom => _classroomRepository.Value;
    public ICompletedSlotRepository CompletedSlot => _completedSlotRepository.Value;
    public IDepartmentRepository Department => _departmentRepository.Value;
    public IGenericRepository<Detail> Detail => _detailRepository.Value;
    public IDisciplineRepository Discipline => _disciplineRepository.Value;
    public IGroupRepository Group => _grroupRepository.Value;
    public ISubgroupRepository Subgroup => _subgroupRepository.Value;
    public IGenericRepository<Subject> Subject => _subjectRepository.Value;
    public IGenericRepository<SubjectType> SubjectType => _subjectTypeRepository.Value;
    public ITeacherRepository Teacher => _teacherRepository.Value;

    public async Task SaveChangesAsync(CancellationToken cancellationToken) =>
        await context.SaveChangesAsync(cancellationToken);

    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!disposed && disposing)
        {
            context.Dispose();
        }

        disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}