using System;
using System.IO;
using System.Net.Http;
using System.Text.Json.Nodes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.UI.Xaml;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using WinUI.Services;
using WinUI.Services.Navigation;
using WinUI.ViewModels;
using WinUI.Views;

namespace WinUI;

public partial class App : Application
{
    private static IHost? _host;
    private Window? _mainWindow;

    public App()
    {
        this.InitializeComponent();
        _host = CreateHostBuilder().Build();
    }

    public static T GetService<T>() where T : notnull
    {
        if (_host is null)
        {
            throw new InvalidOperationException("Host not initialized");
        }

        return _host.Services.GetRequiredService<T>();
    }

    protected override async void OnLaunched(LaunchActivatedEventArgs args)
    {
        if (_host is null)
        {
            throw new InvalidOperationException("Host not initialized");
        }

        await _host.StartAsync();

        _mainWindow = _host.Services.GetRequiredService<MainWindow>();
        _mainWindow.Closed += async (_, _) =>
        {
            if (_host is not null)
            {
                await _host.StopAsync();
                _host.Dispose();
                _host = null;
            }
        };

        _mainWindow.Activate();
    }

    private static IHostBuilder CreateHostBuilder()
    {
        var apiSettingsPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Api", "appsettings.json"));
        var json = File.Exists(apiSettingsPath) ? File.ReadAllText(apiSettingsPath) : "{}";
        JsonNode? root = JsonNode.Parse(json);
        string conn = root?["ConnectionStrings"]?["Default"]?.ToString() ?? string.Empty;
        string levelStr = root?["Serilog"]?["MinimumLevel"]?["Default"]?.ToString() ?? "Information";
        var level = Enum.TryParse<LogEventLevel>(levelStr, true, out var lvl) ? lvl : LogEventLevel.Information;

        return Host.CreateDefaultBuilder()
            .UseSerilog((context, services, lc) =>
            {
                lc.MinimumLevel.Is(level)
                  .WriteTo.MSSqlServer(conn, new MSSqlServerSinkOptions { TableName = "Logs", AutoCreateSqlTable = true });
            })
            .ConfigureServices((context, services) =>
            {
                services.AddSingleton<MainWindow>();

                services.AddSingleton<INavigationService, NavigationService>();

                services.AddTransient<MainViewModel>();
                services.AddTransient<HomeViewModel>();
                services.AddTransient<CalibrationViewModel>();
                services.AddTransient<SimulationViewModel>();
                services.AddTransient<ReportingViewModel>();
                services.AddTransient<MailViewModel>();
                services.AddTransient<SettingsViewModel>();

                RegisterServices(context, services);
            });
    }

    private static void RegisterServices(HostBuilderContext context, IServiceCollection services)
    {
        services.AddHttpClient<IPlcDataService, PlcDataService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddHttpClient<IStationService, StationService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddScoped<IStationInformationService, StationInformationService>();

        services.AddHttpClient<ISaisApiService, SaisApiService>()
            .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddHttpClient<IApiEndpointService, ApiEndpointService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddHttpClient<ILogService, LogService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options =>
        {
            options.Retry.MaxRetryAttempts = 3;
            options.AttemptTimeout.Timeout = TimeSpan.FromSeconds(15);
        });

        services.AddHttpClient<IUserService, UserService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddHttpClient<IMailAlarmService, MailAlarmService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddHttpClient<IMailSettingsService, MailSettingsService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddHttpClient<ICalibrationMeasurementService, CalibrationMeasurementService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddHttpClient<ICalibrationLimitService, CalibrationLimitService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddHttpClient<ITicketService, TicketService>()
            .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddSingleton<IReportExportService, ReportExportService>();
        services.AddSingleton<IChannelNameProvider, ChannelNameProvider>();

        services.AddHttpClient<IMeasurementReportService, MeasurementReportService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        });

        services.AddHttpClient<ISendDataService, SendDataService>(client =>
        {
            string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
            client.BaseAddress = new Uri(baseUrl.TrimEnd('/'));
        })
        .ConfigurePrimaryHttpMessageHandler(() =>
        {
            var handler = new HttpClientHandler();
            if (context.HostingEnvironment.IsDevelopment())
            {
                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
            }

            return handler;
        })
        .AddStandardResilienceHandler(options => options.Retry.MaxRetryAttempts = 3);

        services.AddSingleton<IDatabaseSearchEngine, SqlDatabaseSearchEngine>();
        services.AddSingleton<IDatabaseSelectionService, DatabaseSelectionService>();
        services.AddHostedService<TicketRefreshService>();
        services.AddHostedService<PlcDataSendService>();
    }
}
