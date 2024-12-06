using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class SubjectService(IUnitOfWork unitOfWork) : ISubjectService
{
    public async Task<IEnumerable<SubjectModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var Subjects = await unitOfWork.Subject.GetAllBaseAsync(cancellationToken);

        var models = Subjects.Adapt<IEnumerable<SubjectModel>>();

        return models;
    }

    public async Task<SubjectModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var SubjectEntity = await unitOfWork.Subject.GetByConditionAsListAsync(c => c.Id == id, cancellationToken);
        var SubjectModel = SubjectEntity.Adapt<SubjectModel>();

        return SubjectModel;
    }

    public async Task<SubjectModel> AddAsync(SubjectModel model, CancellationToken cancellationToken)
    {
        var entity = model.Adapt<Subject>();

        await unitOfWork.Subject.Add(entity, cancellationToken);
        var modelToReturn = entity.Adapt<SubjectModel>();

        return modelToReturn;
    }

    public async Task<SubjectModel> UpdateAsync(SubjectModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Subject.GetByConditionAsync(c => c.Id == model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Subject), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Subject.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<SubjectModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Subject.GetByConditionAsync(c => c.Id == id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Subject), id));

        unitOfWork.Subject.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }

}
