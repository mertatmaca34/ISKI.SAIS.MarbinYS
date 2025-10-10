using Api.BackgroundServices;
using Api.Constants;
using Application;
using Infrastructure;
using Infrastructure.Persistence;
using ISKI.Core.CrossCuttingConcerns.Exceptions.ExceptionHandling;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Serilog.Formatting.Json;
using System;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

builder.Host.UseSerilog((ctx, services, lc) =>
{
    var programData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
    var logsDirectory = Path.Combine(programData, LogsConstants.ApplicationFolderName, LogsConstants.DirectoryName);
    Directory.CreateDirectory(logsDirectory);
    var logFilePath = Path.Combine(logsDirectory, LogsConstants.RollingFileNamePattern);

    lc.ReadFrom.Configuration(ctx.Configuration)
      .WriteTo.Console()
      .WriteTo.File(new JsonFormatter(renderMessage: true), logFilePath,
          rollingInterval: RollingInterval.Day,
          shared: true);
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
