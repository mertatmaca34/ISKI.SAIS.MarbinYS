using Application;
using Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApplication();
builder.Services.AddInfrastructure(builder.Configuration.GetConnectionString("Default") ?? string.Empty);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
