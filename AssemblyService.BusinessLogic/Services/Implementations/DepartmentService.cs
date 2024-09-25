using AssemblyService.BusinessLogic.Models;
using AssemblyService.BusinessLogic.Services.Interfaces;
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
}