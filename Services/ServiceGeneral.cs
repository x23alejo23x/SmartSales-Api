using Iceberg_Dashboard_api.Services.ServiceCors;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiWebAPI.Services;
using SmartSales_Api.Services.ServiceDB;

namespace SmartSales_Api.Services
{
    public static class ServiceGeneral
    {
        public static IServiceCollection AddServicesGeneral(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseConnections(configuration);
            services.AddCorsService(configuration); 
            services.AddSwaggerService();
            return services;
        }
    }
}
