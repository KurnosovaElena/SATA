using AssemblyService.BusinessLogic.DI;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.API.Extensions
{
    public static class ServicesConfiguration
    {
        public static void AddApiDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBLLDependencies(configuration);
        }
    }
}
