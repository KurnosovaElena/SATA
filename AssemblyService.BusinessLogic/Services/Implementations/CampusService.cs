using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssemblyService.BusinessLogic.Services.Interfaces;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class CampusService(IUnitOfWork unitOfWork) : ICampusService
{
    public async Task<CampusModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var CampusEntity = await unitOfWork.Campus.GetByConditionAsListAsync(c => c.Id == id, cancellationToken);
        var CampusToReturn = CampusEntity.Adapt<CampusModel>();

        return CampusToReturn;
    }

    public async Task<IEnumerable<CampusModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var entity = await unitOfWork.Campus.GetAllBaseAsync(cancellationToken);

        var model = entity.Adapt<IEnumerable<CampusModel>>();
        return model;
    }

    public async Task<CampusModel> AddAsync(CampusModel model, CancellationToken cancellationToken)
    {
        var modelEntity = model.Adapt<Campus>();

        await unitOfWork.Campus.Add(modelEntity, cancellationToken);
        var modelToReturn = modelEntity.Adapt<CampusModel>();

        return modelToReturn;
    }

    public async Task<CampusModel> UpdateAsync(CampusModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Campus.GetByConditionAsync(c => c.Id == model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Campus), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Campus.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<CampusModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Campus.GetByConditionAsync(c => c.Id == id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Campus), id));

        unitOfWork.Campus.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}