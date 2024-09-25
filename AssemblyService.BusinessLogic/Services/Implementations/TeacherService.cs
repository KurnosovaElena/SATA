using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;
public class TeacherService(IUnitOfWork unitOfWork) : ITeacherService
{
    public async Task<TeacherModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var teacherEntity = await unitOfWork.Teacher.GetByIdAsync(id, cancellationToken);

        var teacherModel = teacherEntity.Adapt<TeacherModel>();

        return teacherModel;
    }
}
