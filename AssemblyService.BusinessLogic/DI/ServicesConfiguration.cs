using AssemblyService.DataAccess.DI;
using Mapster;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AssemblyService.BusinessLogic.DI;

public static class ServicesConfiguration
{
    /// <summary>
    /// Inject Dependencies from Business Logic Layer 
    /// </summary>
    /// <param name="services">Collection of services from API</param>
    /// <param name="configuration">Configuration properties from API</param>
    public static void AddBLLDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDataAccessDependencies(configuration);

        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
    }
}