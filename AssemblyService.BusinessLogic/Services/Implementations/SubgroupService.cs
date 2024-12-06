using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class SubgroupService(IUnitOfWork unitOfWork) : ISubgroupService
{
    public async Task<IEnumerable<SubgroupModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var entity = await unitOfWork.Subgroup.GetAllBaseAsync(cancellationToken);

        var model = entity.Adapt<IEnumerable<SubgroupModel>>();

        return model;
    }

    public async Task<SubgroupModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var subgroup = await unitOfWork.Subgroup.GetByIdAsync(id, cancellationToken);

        var subgroupModel = subgroup.Adapt<SubgroupModel>();

        return subgroupModel;
    }

    public async Task<SubgroupModel> AddAsync(SubgroupModel model, CancellationToken cancellationToken)
    {
        var entity = model.Adapt<Subgroup>();

        await unitOfWork.Subgroup.Add(entity, cancellationToken);

        var modelToReturn = entity.Adapt<SubgroupModel>();

        return modelToReturn;
    }

    public async Task<SubgroupModel> UpdateAsync(SubgroupModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Subgroup.GetByIdAsync(model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Subgroup), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Subgroup.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<SubgroupModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Subgroup.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Subgroup), id));

        unitOfWork.Subgroup.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}