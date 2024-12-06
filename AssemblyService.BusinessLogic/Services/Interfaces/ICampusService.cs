using AssemblyService.BusinessLogic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyService.BusinessLogic.Services.Interfaces;
public interface ICampusService
{
    Task<IEnumerable<CampusModel>> GetAllAsync(CancellationToken cancellationToken);
    Task<CampusModel> UpdateAsync(CampusModel model, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
    Task<CampusModel> AddAsync(CampusModel model, CancellationToken cancellationToken);
    Task<CampusModel> GetByIdAsync(Guid id, CancellationToken cancellationToken);

}
