namespace SmartSales_Api.Services.ServiceCors
{
    public static class ServiceCors
    {
        public static IServiceCollection AddCorsService(this IServiceCollection services, IConfiguration configuration)
        {
            /************ Configuración de CORS ************/
            var allowedOrigins = configuration.GetSection("AllowedOrigins").Get<string[]>();
            _ = services.AddCors(options =>
            {
                options.AddPolicy("AllCors",
                    builder =>
                    {
                        //builder.AllowAnyOrigin()
                        builder.WithOrigins(allowedOrigins)
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                    });
            });

            return services;
        }
    }
}
