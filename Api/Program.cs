using Api.BackgroundServices;
using Api.Constants;
using Application;
using Infrastructure;
using Infrastructure.Persistence;
using ISKI.Core.CrossCuttingConcerns.Exceptions.ExceptionHandling;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Sinks.MSSqlServer;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, services, lc) =>
{
    lc.ReadFrom.Configuration(ctx.Configuration)
      .WriteTo.Console();

    var connectionString = ctx.Configuration.GetConnectionString("Default");

    if (string.IsNullOrWhiteSpace(connectionString))
    {
        Console.Error.WriteLine("Serilog SQL sink skipped because the default connection string is not configured.");
        return;
    }

    try
    {
        lc.WriteTo.MSSqlServer(connectionString, new MSSqlServerSinkOptions
        {
            TableName = "Logs",
            AutoCreateSqlTable = true
        });
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine($"Serilog SQL sink initialization failed: {ex.Message}");
    }
});

builder.Services.AddApplication();
var conn = builder.Configuration.GetConnectionString("Default") ?? string.Empty;
if (string.IsNullOrWhiteSpace(conn))
    Log.Warning(LogMessages.Program.ConnectionStringEmpty);
builder.Services.AddInfrastructure(conn);

builder.Services.AddControllers();
builder.Services.AddHostedService<PlcDataWorker>();
builder.Services.AddHostedService<MailAlarmWorker>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var context = scope.ServiceProvider.GetRequiredService<IBKSContext>();
        context.Database.EnsureCreated();
        Log.Information(LogMessages.Program.DatabaseChecked);
    }
    catch (Exception ex)
    {
        Log.Error(ex, LogMessages.Program.DatabaseInitializationFailed);
    }
}

app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/", context =>
{
    context.Response.Redirect("/swagger");
    return Task.CompletedTask;
});

app.UseGlobalExceptionHandling();

app.MapControllers();

Log.Information(LogMessages.Program.ApiStarted);
app.Run();
