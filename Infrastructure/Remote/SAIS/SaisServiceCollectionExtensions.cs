using FluentValidation;
using Infrastructure.Remote.SAIS.Configuration;
using Infrastructure.Remote.SAIS.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Infrastructure.Remote.SAIS;

public static class SaisServiceCollectionExtensions
{
    public static IServiceCollection AddSaisRemote(
        this IServiceCollection services,
        Action<SaisApiOptions> configureOptions)
    {
        services.AddSingleton<IValidator<SaisApiOptions>, SaisApiOptionsValidator>();
        services.AddSingleton<IValidateOptions<SaisApiOptions>>(provider =>
            new FluentValidationOptions<SaisApiOptions>(provider.GetRequiredService<IValidator<SaisApiOptions>>()));

        services.AddOptions<SaisApiOptions>()
            .Configure(configureOptions)
            .ValidateOnStart();

        services.AddHttpClient<ISaisSecurityClient, SaisSecurityClient>(ConfigureClient);
        services.AddHttpClient<ISaisTimeClient, SaisTimeClient>(ConfigureClient);
        services.AddHttpClient<ISaisStationClient, SaisStationClient>(ConfigureClient);
        services.AddHttpClient<ISaisChannelClient, SaisChannelClient>(ConfigureClient);
        services.AddHttpClient<ISaisGeneralInformationClient, SaisGeneralInformationClient>(ConfigureClient);
        services.AddHttpClient<ISaisDataClient, SaisDataClient>(ConfigureClient);
        services.AddHttpClient<ISaisDiagnosticClient, SaisDiagnosticClient>(ConfigureClient);
        services.AddHttpClient<ISaisCalibrationClient, SaisCalibrationClient>(ConfigureClient);
        services.AddHttpClient<ISaisSampleClient, SaisSampleClient>(ConfigureClient);

        services.AddSingleton<ISaisTicketProvider, SaisTicketProvider>();

        return services;
    }

    private static void ConfigureClient(IServiceProvider serviceProvider, HttpClient client)
    {
        var options = serviceProvider.GetRequiredService<IOptions<SaisApiOptions>>().Value;
        if (string.IsNullOrWhiteSpace(options.BaseUrl))
        {
            throw new InvalidOperationException("SAİS API base URL has not been configured.");
        }

        client.BaseAddress = new Uri(options.BaseUrl.TrimEnd('/') + "/", UriKind.Absolute);
    }
}
