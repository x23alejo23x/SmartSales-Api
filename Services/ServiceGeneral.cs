using SmartSales_Api.Services.ServiceCors;
using SmartSales_Api.Services.ServiceControllers;
using SmartSales_Api.Services.ServiceDB;
using SmartSales_Api.Services.ServiceScoped;
using SmartSales_Api.Services.ServiceSwagger;

namespace SmartSales_Api.Services
{
    public static class ServiceGeneral
    {
        public static IServiceCollection AddServicesGeneral(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDatabaseConnections(configuration); 
            services.AddCorsService(configuration);        
            services.AddScopedServices();                  
            services.AddControllerSService();              
            services.AddSwaggerService();                

            return services;
        }
    }
}
