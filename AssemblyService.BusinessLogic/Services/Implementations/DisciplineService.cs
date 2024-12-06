using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;
public class DisciplineService(IUnitOfWork unitOfWork) : IDisciplineService
{
    public async Task<IEnumerable<DisciplineModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var Disciplines = await unitOfWork.Discipline.GetAllBaseAsync(cancellationToken);

        var models = Disciplines.Adapt<IEnumerable<DisciplineModel>>();

        return models;
    }

    public async Task<DisciplineModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var DisciplineEntity = await unitOfWork.Discipline.GetByIdAsync(id, cancellationToken);
        var DisciplineModel = DisciplineEntity.Adapt<DisciplineModel>();

        return DisciplineModel;
    }

    public async Task<DisciplineModel> AddAsync(DisciplineModel model, CancellationToken cancellationToken)
    {
        var entity = model.Adapt<Discipline>();

        await unitOfWork.Discipline.Add(entity, cancellationToken);
        var modelToReturn = entity.Adapt<DisciplineModel>();

        return modelToReturn;
    }

    public async Task<DisciplineModel> UpdateAsync(DisciplineModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Discipline.GetByIdAsync(model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Discipline), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Discipline.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<DisciplineModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Discipline.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Discipline), id));

        unitOfWork.Discipline.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

}
