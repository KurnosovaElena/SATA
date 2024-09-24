using AssemblyService.DataAccess.Context;
using AssemblyService.DataAccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AssemblyService.DataAccess.DI;

/// <summary>
/// Extension class (e.g. Helper class)
/// </summary>
public static class ServicesConfiguration
{
    /// <summary>
    /// Inject Dependencies from Data Access Layer
    /// </summary>
    /// <param name="services">Collection of services from API</param>
    /// <param name="configuration">Configuration properties from API</param>
    public static void AddDataAccessDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        //Database context injection
        services.AddDbContext<TimetableContext>(options =>
        options.UseNpgsql(
            configuration.GetConnectionString("PostgreSQLConnection"), // Connection string from appsettings.json
            connectionOptions => connectionOptions.EnableRetryOnFailure()
            ).UseLazyLoadingProxies());

        //Dependency injection for UnitOfWork
        services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();
    }
}