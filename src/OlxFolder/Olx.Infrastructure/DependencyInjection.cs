using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Olx.Application.Abstraction;
using Olx.Infrastructure.Persistance;

namespace Olx.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var con = $"Data source={Environment.GetEnvironmentVariable("DB_HOST")};" +
                           $"Initial Catalog={Environment.GetEnvironmentVariable("DB_NAME")};" +
                           $"User ID=SA;Password={Environment.GetEnvironmentVariable("SA_PASSWORD")};" +
                           $"TrustServerCertificate=True;";

            services.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
            options.UseSqlServer(con));
            return services;
        }
    }
}
