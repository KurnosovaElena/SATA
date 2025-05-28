using AssemblyService.BusinessLogic.DI;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

namespace AssemblyService.API.Extensions
{
    public static class ServicesConfiguration
    {
        public static void AddApiDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBLLDependencies(configuration);

            // 1. Add Authentication Services
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.Authority = "https://dev-csticfkrvwhxizog.us.auth0.com/";
                options.Audience = "https://semi-automatic-timetable";
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    NameClaimType = ClaimTypes.NameIdentifier
                };
            });

            services
      .AddAuthorization(options =>
      {
          options.AddPolicy(
            "update:timetable",
            policy => policy.Requirements.Add(
              new HasScopeRequirement("update:timetable", "dev-csticfkrvwhxizog.us.auth0.com")
            )
          );
          options.AddPolicy(
  "update:slot",
  policy => policy.Requirements.Add(
    new HasScopeRequirement("update:slot", "dev-csticfkrvwhxizog.us.auth0.com")
  )
);

      });

            services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();
        }
    }
}
