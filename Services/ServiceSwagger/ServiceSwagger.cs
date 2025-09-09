using Microsoft.Extensions.DependencyInjection;

namespace SmartSales_Api.Services.ServiceSwagger
{
    public static class ServiceSwagger
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
