using System;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Application.Features.PlcData.Commands.ReadAndSavePlcData;

namespace Api.BackgroundServices;

/// <summary>
/// Periodically executes <see cref="ReadAndSavePlcDataCommand"/> to retrieve
/// measurements from the PLC.
/// </summary>
public class PlcDataWorker(
    ILogger<PlcDataWorker> logger,
    IServiceProvider serviceProvider,
    IConfiguration configuration) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        int interval = configuration.GetValue<int>("PlcSettings:IntervalSeconds", 5);
        while (!stoppingToken.IsCancellationRequested)
        {
            using IServiceScope scope = serviceProvider.CreateScope();
            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            var cmd = new ReadAndSavePlcDataCommand(
                configuration["PlcSettings:IpAddress"] ?? "10.33.7.253",
                configuration.GetValue<int>("PlcSettings:AnalogDb"),
                configuration.GetValue<int>("PlcSettings:AnalogStart"),
                configuration.GetValue<int>("PlcSettings:AnalogLength"),
                configuration.GetValue<int>("PlcSettings:DigitalDb"),
                configuration.GetValue<int>("PlcSettings:DigitalStart"),
                configuration.GetValue<int>("PlcSettings:DigitalLength"),
                configuration.GetValue<int>("PlcSettings:TimeParameterDb"),
                configuration.GetValue<int>("PlcSettings:TimeParameterStart"),
                configuration.GetValue<int>("PlcSettings:TimeParameterLength"));

            try
            {
                await mediator.Send(cmd, stoppingToken);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error while reading PLC data");
            }
            await Task.Delay(TimeSpan.FromSeconds(interval), stoppingToken);
        }
    }
}
