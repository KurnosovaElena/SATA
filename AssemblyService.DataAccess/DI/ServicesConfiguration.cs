using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AssemblyService.DataAccess.DI;
public static class ServicesConfiguration
{
    public static void AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TimetableContext>(options =>
        options.UseNpgsql(
            configuration.GetConnectionString("PostgreSQLConnection"),
            connectionOptions => connectionOptions.EnableRetryOnFailure()
            ).UseLazyLoadingProxies());

        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
    }
}
