using AssemblyService.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace AssemblyService.API.Extensions
{
    public static class ServicesConfiguration
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
            services.AddDbContext<TimetableContext>(options => options.UseNpgsql(configuration.GetConnectionString("DbConnection"), x => x.MigrationsAssembly(nameof(Infrastructure))));
    }
}
