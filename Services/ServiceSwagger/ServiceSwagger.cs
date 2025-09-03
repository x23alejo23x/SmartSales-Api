using Microsoft.Extensions.DependencyInjection;

namespace MiWebAPI.Services
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
