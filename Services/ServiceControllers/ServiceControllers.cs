namespace SmartSales_Api.Services.ServiceControllers
{
    public static class ServiceControllers
    {
        public static IServiceCollection AddControllerSService(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            return services;
        }
    }
}
