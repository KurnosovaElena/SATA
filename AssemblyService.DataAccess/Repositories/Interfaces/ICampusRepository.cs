using AssemblyService.DataAccess.Entities;

namespace AssemblyService.DataAccess.Repositories.Interfaces;
public interface ICampusRepository
{
    Task<Campus> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}
