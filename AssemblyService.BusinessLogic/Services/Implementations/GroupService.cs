using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;

internal class GroupService(IUnitOfWork unitOfWork) : IGroupService
{
    public async Task<IEnumerable<GroupModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var Groups = await unitOfWork.Group.GetAllBaseAsync(cancellationToken);

        var models = Groups.Adapt<IEnumerable<GroupModel>>();

        return models;
    }

    public async Task<GroupModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var GroupEntity = await unitOfWork.Group.GetByIdAsync(id, cancellationToken);

        var GroupModel = GroupEntity.Adapt<GroupModel>();

        return GroupModel;
    }

    public async Task<GroupModel> AddAsync(GroupModel model, CancellationToken cancellationToken)
    {
        var entity = model.Adapt<GroupEntity>();

        await unitOfWork.Group.Add(entity, cancellationToken);
        var modelToReturn = entity.Adapt<GroupModel>();

        return modelToReturn;
    }

    public async Task<GroupModel> UpdateAsync(GroupModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Group.GetByIdAsync(model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(GroupEntity), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Group.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<GroupModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Group.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(GroupEntity), id));

        unitOfWork.Group.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}