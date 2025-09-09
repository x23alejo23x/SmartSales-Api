using SmartSales_Api.Events;

namespace SmartSales_Api.Services.ServiceScoped
{
    public static class ServiceScoped
    {
        public static IServiceCollection AddScopedServices(this IServiceCollection services)
        {
            services.AddScoped<ICategoria, CategoriaMethod>();
            return services;
        }
    }
}
