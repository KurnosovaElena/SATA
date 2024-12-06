using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class CompletedSlotService(IUnitOfWork unitOfWork) : ICompletedSlotService
{
    public async Task<CompletedSlotModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var CompletedSlotEntity = await unitOfWork.CompletedSlot.GetByIdAsync(id, cancellationToken);

        var CompletedSlotToReturn = CompletedSlotEntity.Adapt<CompletedSlotModel>();

        return CompletedSlotToReturn;
    }

    public async Task<IEnumerable<CompletedSlotModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var entity = await unitOfWork.CompletedSlot.GetAllBaseAsync(cancellationToken);

        var model = entity.Adapt<IEnumerable<CompletedSlotModel>>();

        return model;
    }

    public async Task<CompletedSlotModel> AddAsync(CompletedSlotModel model, CancellationToken cancellationToken)
    {
        var modelEntity = model.Adapt<CompletedSlot>();

        await unitOfWork.CompletedSlot.Add(modelEntity, cancellationToken);

        var modelToReturn = modelEntity.Adapt<CompletedSlotModel>();

        return modelToReturn;
    }

    public async Task<CompletedSlotModel> UpdateAsync(CompletedSlotModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.CompletedSlot.GetByIdAsync(model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(CompletedSlot), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.CompletedSlot.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<CompletedSlotModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.CompletedSlot.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(CompletedSlot), id));

        unitOfWork.CompletedSlot.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}