using AssemblyService.BusinessLogic.Services.Implementations;
using AssemblyService.BusinessLogic.Services.Interfaces;
using AssemblyService.DataAccess.DI;
using Mapster;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AssemblyService.BusinessLogic.DI;

/// <summary>
/// Extension class (e.g. Helper class)
/// </summary>
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

        services.AddServiceDependencies();
    }

    private static void AddServiceDependencies(this IServiceCollection services)
    {
        services.AddScoped<ITimetableService, TimetableService>();
        services.AddScoped<ICompletedSlotService, CompletedSlotService>();
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<ITeacherService, TeacherService>();
        services.AddScoped<ISubjectService, SubjectService>();
        services.AddScoped<ICampusService, CampusService>();
        services.AddScoped<IDetailService, DetailService>();
        services.AddScoped<IDisciplineService, DisciplineService>();
        services.AddScoped<IClassroomService, ClassroomService>();
        services.AddScoped<ISubgroupService, SubgroupService>();
    }
}