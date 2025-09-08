namespace TuProyecto.Services.ServiceScoped
{
    public static class ServiceScoped
    {
        public static IServiceCollection AddScopedServices(this IServiceCollection services)
        {
            // Aquí vas registrando tus interfaces e implementaciones
            // Ejemplo:
            // services.AddScoped<INombreServicio, NombreServicio>();

            return services;
        }
    }
}
