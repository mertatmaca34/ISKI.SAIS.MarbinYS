using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence;
using Infrastructure.Services.PLC;
using Domain.Repositories;
using Infrastructure.Remote.SAIS;
using Infrastructure.Remote.SAIS.Configuration;

namespace Infrastructure;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        string connectionString,
        Action<SaisApiOptions>? configureSais = null)
    {
        services.AddDbContext<IBKSContext>(options =>
            options.UseSqlServer(connectionString));

        services.AddScoped<IMailSettingsRepository, MailSettingsRepository>();
        services.AddScoped<ISendDataRepository, SendDataRepository>();
        services.AddScoped<IApiEndpointRepository, ApiEndpointRepository>();
        services.AddScoped<ICalibrationLimitRepository, CalibrationLimitRepository>();
        services.AddScoped<ICalibrationMeasurementRepository, CalibrationMeasurementRepository>();
        services.AddScoped<IDigitalSensorDataRepository, DigitalSensorDataRepository>();
        services.AddScoped<IAnalogSensorDataRepository, AnalogSensorDataRepository>();
        services.AddScoped<IPlcInformationRepository, PlcInformationRepository>();
        services.AddScoped<IStationRepository, StationRepository>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IMailAlarmRepository, MailAlarmRepository>();
        services.AddScoped<IUserMailAlarmRepository, UserMailAlarmRepository>();
        services.AddSingleton<IPlcClient, SiemensPlcClient>();
        services.AddSingleton<IPlcDataCache, PlcDataCache>();

        if (configureSais is not null)
        {
            services.AddSaisRemote(configureSais);
        }

        return services;
    }
}
