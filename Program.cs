using SmartSales_Api.WebAPI;
using SmartSales_Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServicesGeneral(builder.Configuration); 

var app = builder.Build();

app.ConfigureApplication();

app.Run();
