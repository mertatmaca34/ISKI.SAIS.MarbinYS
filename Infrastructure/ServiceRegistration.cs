using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Services.PLC;
using Domain.Repositories;

namespace Infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<IBKSContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IMailTriggerRepository, MailTriggerRepository>();
        services.AddScoped<IMailSettingsRepository, MailSettingsRepository>();
        services.AddScoped<IMailUserRepository, MailUserRepository>();
        services.AddScoped<IMailLogRepository, MailLogRepository>();
        services.AddScoped<IMailTriggerRecipientRepository, MailTriggerRecipientRepository>();
        services.AddScoped<ISendDataRepository, SendDataRepository>();
        services.AddScoped<IApiEndpointRepository, ApiEndpointRepository>();
        services.AddScoped<ICalibrationLimitRepository, CalibrationLimitRepository>();
        services.AddScoped<ICalibrationMeasurementRepository, CalibrationMeasurementRepository>();
        services.AddScoped<IDigitalSensorDataRepository, DigitalSensorDataRepository>();
        services.AddScoped<IAnalogSensorDataRepository, AnalogSensorDataRepository>();
        services.AddScoped<IPlcInformationRepository, PlcInformationRepository>();
        services.AddScoped<IStationRepository, StationRepository>();
        services.AddSingleton<IPlcClient, SiemensPlcClient>();
        services.AddSingleton<IPlcDataCache, PlcDataCache>();

        return services;
    }
}
