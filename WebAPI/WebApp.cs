namespace SmartSales_Api.WebAPI
{
    public static class WebApp
    {
        public static WebApplication ConfigureApplication(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                app.MapControllers();
            }

            app.MapGet("/", () => "Backend SmartSales Up! 🚀").WithTags("General");

            return app;
        }
    }
}
