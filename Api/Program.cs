using Api.BackgroundServices;
using Application;
using Infrastructure;
using Infrastructure.Persistence;
using ISKI.Core.CrossCuttingConcerns.Exceptions.ExceptionHandling;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, lc) => lc.ReadFrom.Configuration(ctx.Configuration));

builder.Services.AddApplication();
var conn = builder.Configuration.GetConnectionString("Default") ?? string.Empty;
if (string.IsNullOrWhiteSpace(conn))
    Log.Warning("Connection string is empty");
builder.Services.AddInfrastructure(conn);

builder.Services.AddControllers();
builder.Services.AddHostedService<PlcDataWorker>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var context = scope.ServiceProvider.GetRequiredService<IBKSContext>();
        context.Database.EnsureCreated();
        Log.Information("Database checked");
    }
    catch (Exception ex)
    {
        Log.Error(ex, "Database initialization failed");
    }
}

app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.UseMiddleware<ExceptionMiddleware>();

app.MapControllers();

Log.Information("API started");
app.Run();
