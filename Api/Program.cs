using Application;
using Infrastructure;
using Api.BackgroundServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString("Default") ?? string.Empty);

builder.Services.AddControllers();
builder.Services.AddHostedService<PlcDataWorker>();

var app = builder.Build();

app.MapControllers();

app.Run();
