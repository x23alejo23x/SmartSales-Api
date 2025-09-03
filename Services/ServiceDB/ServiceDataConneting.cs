using Microsoft.EntityFrameworkCore;
using SmartSales_Api.Context;

namespace SmartSales_Api.Services.ServiceDB
{
    public static class DatabaseConfigurationExtensions
    {
        public static IServiceCollection AddDatabaseConnections(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
