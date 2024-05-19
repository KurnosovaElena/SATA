using AssemblyService.Domain.Entities.Models;
using AssemblyService.Domain.Interfaces;
using AssemblyService.Domain.Interfaces.Repositories;
using AssemblyService.Infrastructure.Context;
using AssemblyService.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.Infrastructure
{
    public class UnitOfWork(TimetableContext context) : IUnitOfWork
    {
        private readonly Lazy<IRepositoryBase<Campus>> _campusRepository = new(new RepositoryBase<Campus>(context));
        private readonly Lazy<IClassroomRepository> _classroomRepository = new(new ClassroomRepository(context));
        private readonly Lazy<ICompletedSlotRepository> _completedSlotRepository = new(new CompletedSlotRepository(context));
        private readonly Lazy<IDepartmentRepository> _departmentRepository = new(new DepartmentRepository(context));
        private readonly Lazy<IRepositoryBase<Detail>> _detailRepository = new(new RepositoryBase<Detail>(context));
        private readonly Lazy<IDisciplineRepository> _disciplineRepository = new(new DisciplineRepository(context));
        private readonly Lazy<IGroupRepository> _grroupRepository = new(new GroupRepository(context));
        private readonly Lazy<IRepositoryBase<Subgroup>> _subgroupRepository = new(new RepositoryBase<Subgroup>(context));
        private readonly Lazy<IRepositoryBase<Subject>> _subjectRepository = new(new RepositoryBase<Subject>(context));
        private readonly Lazy<IRepositoryBase<SubjectType>> _subjectTypeRepository = new(new RepositoryBase<SubjectType>(context));
        private readonly Lazy<ITeacherRepository> _teacherRepository = new(new TeacherRepository(context));

        public IRepositoryBase<Campus> Campus => _campusRepository.Value;
        public IClassroomRepository Classroom => _classroomRepository.Value;
        public ICompletedSlotRepository CompletedSlot => _completedSlotRepository.Value;
        public IDepartmentRepository Department => _departmentRepository.Value;
        public IRepositoryBase<Detail> Detail => _detailRepository.Value;
        public IDisciplineRepository Discipline => _disciplineRepository.Value;
        public IGroupRepository Group => _grroupRepository.Value;
        public IRepositoryBase<Subgroup> Subgroup => _subgroupRepository.Value;
        public IRepositoryBase<Subject> Subject => _subjectRepository.Value;
        public IRepositoryBase<SubjectType> SubjectType => _subjectTypeRepository.Value;
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
}
