using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.UnitOfWork;

namespace AssemblyService.BusinessLogic.Services.Implementations;

public class CompletedSlotService(IUnitOfWork unitOfWork) : ICompletedSlotService
{
}
