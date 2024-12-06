using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class TeacherService(IUnitOfWork unitOfWork) : ITeacherService
{
    public async Task<IEnumerable<TeacherModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var teachers = await unitOfWork.Teacher.GetAllBaseAsync(cancellationToken);

        var models = teachers.Adapt<IEnumerable<TeacherModel>>();

        return models;
    }

    public async Task<TeacherModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var teacherEntity = await unitOfWork.Teacher.GetByIdAsync(id, cancellationToken);

        var teacherModel = teacherEntity.Adapt<TeacherModel>();

        return teacherModel;
    }

    public async Task<TeacherModel> AddAsync(TeacherModel model, CancellationToken cancellationToken)
    {
        var entity = model.Adapt<Teacher>();

        await unitOfWork.Teacher.Add(entity, cancellationToken);

        var modelToReturn = entity.Adapt<TeacherModel>();

        return modelToReturn;
    }

    public async Task<TeacherModel> UpdateAsync(TeacherModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Teacher.GetByIdAsync(model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Teacher), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Teacher.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<TeacherModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Teacher.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Teacher), id));

        unitOfWork.Teacher.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}