using AssemblyService.BusinessLogic.Exceptions;
using AssemblyService.BusinessLogic.Exceptions.ExceptionMessages;
using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.Entities;
using AssemblyService.DataAccess.UnitOfWork;
using Mapster;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class DepartmentService(IUnitOfWork unitOfWork) : IDepartmentService
{
    public async Task<DepartmentModel> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var departmentEntity = await unitOfWork.Department.GetByIdAsync(id, cancellationToken);

        var departmentToReturn = departmentEntity.Adapt<DepartmentModel>();

        return departmentToReturn;
    }

    public async Task<IEnumerable<DepartmentModel>> GetAllAsync(CancellationToken cancellationToken)
    {
        var entity = await unitOfWork.Department.GetAllAsync(cancellationToken);

        var model = entity.Adapt<IEnumerable<DepartmentModel>>();

        return model;
    }

    public async Task<DepartmentModel> AddAsync(DepartmentModel model, CancellationToken cancellationToken)
    {
        var modelEntity = model.Adapt<Department>();

        await unitOfWork.Department.Add(modelEntity, cancellationToken);

        var modelToReturn = modelEntity.Adapt<DepartmentModel>();

        return modelToReturn;
    }

    public async Task<DepartmentModel> UpdateAsync(DepartmentModel model, CancellationToken cancellationToken)
    {
        var modelToUpdate = await unitOfWork.Department.GetByIdAsync(model.Id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Department), model.Id));

        modelToUpdate.Adapt(model);

        unitOfWork.Department.Update(modelToUpdate);
        await unitOfWork.SaveChangesAsync(cancellationToken);

        var modelToReturn = modelToUpdate.Adapt<DepartmentModel>();

        return modelToReturn;
    }

    public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        var modelToDelete = await unitOfWork.Department.GetByIdAsync(id, cancellationToken)
            ?? throw new NotFoundException(ExceptionMessages.EntityNotFoundMessage(nameof(Department), id));

        unitOfWork.Department.Delete(modelToDelete);
        await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}