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
public class DetailService(IUnitOfWork unitOfWork) : IDetailService
{
    public async Task<DetailModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var DetailEntity = await unitOfWork.Detail.GetByConditionAsync(d => d.Id==id, cancellationToken);

        var DetailToReturn = DetailEntity.Adapt<DetailModel>();

        return DetailToReturn;
    }

    public async Task<IEnumerable<DetailModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var entity = await unitOfWork.Detail.GetAllAsListAsync(cancellationToken);

        var model = entity.Adapt<IEnumerable<DetailModel>>();

        return model;
    }

    public async Task<DetailModel> AddAsync(DetailModel model, CancellationToken cancellationToken)
    {
        var modelEntity = model.Adapt<Detail>();

        await unitOfWork.Detail.Add(modelEntity, cancellationToken);
        var modelToReturn = modelEntity.Adapt<DetailModel>();

        return modelToReturn;
    }

    public async Task<DetailModel> UpdateAsync(DetailModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Detail.GetByConditionAsync(d => d.Id == model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Detail), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Detail.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<DetailModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Detail.GetByConditionAsync(d => d.Id == id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Detail), id));

        unitOfWork.Detail.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
