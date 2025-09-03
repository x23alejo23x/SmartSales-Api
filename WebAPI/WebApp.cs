namespace MiWebAPI.WebAPI;

public static class WebApp
{
    public static WebApplication ConfigureApplication(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // Endpoint inicial
        app.MapGet("/", () => "Backend SmartSales Up!").WithTags("General");

        return app;
    }
}
