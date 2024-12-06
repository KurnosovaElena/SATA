using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;
public class ClassroomService(IUnitOfWork unitOfWork) : IClassroomService
{
    public async Task<ClassroomModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var ClassroomEntity = await unitOfWork.Classroom.GetByIdAsync(id, cancellationToken);
        var ClassroomToReturn = ClassroomEntity.Adapt<ClassroomModel>();

        return ClassroomToReturn;
    }

    public async Task<IEnumerable<ClassroomModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var entity = await unitOfWork.Classroom.GetAllBaseAsync(cancellationToken);

        var model = entity.Adapt<IEnumerable<ClassroomModel>>();
        return model;
    }

    public async Task<ClassroomModel> AddAsync(ClassroomModel model, CancellationToken cancellationToken)
    {
        var modelEntity = model.Adapt<Classroom>();

        await unitOfWork.Classroom.Add(modelEntity, cancellationToken);
        var modelToReturn = modelEntity.Adapt<ClassroomModel>();

        return modelToReturn;
    }

    public async Task<ClassroomModel> UpdateAsync(ClassroomModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Classroom.GetByIdAsync(model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Classroom), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Classroom.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<ClassroomModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Classroom.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Classroom), id));

        unitOfWork.Classroom.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

}
