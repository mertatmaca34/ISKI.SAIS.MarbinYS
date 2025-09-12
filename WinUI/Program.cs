using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.MSSqlServer;
using System.Text.Json.Nodes;
using WinUI.Forms;
using WinUI.Pages;
using WinUI.Services;

namespace WinUI
{
    internal static class Program
    {
        internal static IServiceProvider? Services { get; private set; }
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            SplashScreenForm splash = new SplashScreenForm();
            var splashThread = new Thread(() =>
            {
                Application.Run(splash);
            });
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            var host = CreateHostBuilder(args).Build();
            Log.Information("WinUI started");
            Services = host.Services;
            using var scope = Services.CreateScope();
            var services = scope.ServiceProvider;

            var mainForm = services.GetRequiredService<MainForm>();

            splash.Invoke(() => splash.Close());
            splashThread.Join();

            Application.Run(mainForm);
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            var apiSettingsPath = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "Api", "appsettings.json"));
            var json = File.Exists(apiSettingsPath) ? File.ReadAllText(apiSettingsPath) : "{}";
            JsonNode? root = JsonNode.Parse(json);
            string conn = root?["ConnectionStrings"]?["Default"]?.ToString() ?? string.Empty;
            string levelStr = root?["Serilog"]?["MinimumLevel"]?["Default"]?.ToString() ?? "Information";
            var level = Enum.TryParse<LogEventLevel>(levelStr, true, out var lvl) ? lvl : LogEventLevel.Information;

            return Host.CreateDefaultBuilder(args)
                .UseSerilog((ctx, services, lc) =>
                {
                    lc.MinimumLevel.Is(level)
                      .WriteTo.MSSqlServer(conn, new MSSqlServerSinkOptions { TableName = "Logs", AutoCreateSqlTable = true });
                })
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<MainForm>();
                    services.AddSingleton<HomePage>();
                    services.AddSingleton<CalibrationPage>();
                    services.AddSingleton<SimulationPage>();
                    services.AddSingleton<ReportingPage>();
                    services.AddSingleton<MailPage>();

                    services.AddHttpClient<IPlcDataService, PlcDataService>(client =>
                    {
                        string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730"; baseUrl = baseUrl.TrimEnd('/');
                        client.BaseAddress = new Uri(baseUrl);
                    })

                        .ConfigurePrimaryHttpMessageHandler(() =>
                        {
                            var handler = new HttpClientHandler();
                            if (context.HostingEnvironment.IsDevelopment())
                            {
                                handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                            }
                            return handler;
                        }).AddStandardResilienceHandler(options =>
                            options.Retry.MaxRetryAttempts = 3);

                    services.AddHttpClient<IStationService, StationService>(client =>
                    {
                        string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
                        baseUrl = baseUrl.TrimEnd('/');
                        client.BaseAddress = new Uri(baseUrl);
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
                        options.Retry.MaxRetryAttempts = 3);

                    services.AddHttpClient<IStationInformationService, StationInformationService>()
                        .AddStandardResilienceHandler(options =>
                            options.Retry.MaxRetryAttempts = 3);
                    services.AddHttpClient<ISaisApiService, SaisApiService>()
                        .AddStandardResilienceHandler(options =>
                            options.Retry.MaxRetryAttempts = 3);

                    services.AddHttpClient<IApiEndpointService, ApiEndpointService>(client =>
                    {
                        string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
                        baseUrl = baseUrl.TrimEnd('/');
                        client.BaseAddress = new Uri(baseUrl);
                    })

                    .ConfigurePrimaryHttpMessageHandler(() =>
                    {
                        var handler = new HttpClientHandler();
                        if (context.HostingEnvironment.IsDevelopment())
                        {
                            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                        }
                        return handler;
                    }).AddStandardResilienceHandler(options =>
                        options.Retry.MaxRetryAttempts = 3);

                    services.AddHttpClient<ILogService, LogService>(client =>
                    {
                        string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
                        baseUrl = baseUrl.TrimEnd('/');
                        client.BaseAddress = new Uri(baseUrl);
                    })

                    .ConfigurePrimaryHttpMessageHandler(() =>
                    {
                        var handler = new HttpClientHandler();
                        if (context.HostingEnvironment.IsDevelopment())
                        {
                            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                        }
                        return handler;
                    }).AddStandardResilienceHandler(options =>
                        options.Retry.MaxRetryAttempts = 3);

                    services.AddHttpClient<ICalibrationMeasurementService, CalibrationMeasurementService>(client =>
                    {
                        string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
                        baseUrl = baseUrl.TrimEnd('/');
                        client.BaseAddress = new Uri(baseUrl);
                    })

                    .ConfigurePrimaryHttpMessageHandler(() =>
                    {
                        var handler = new HttpClientHandler();
                        if (context.HostingEnvironment.IsDevelopment())
                        {
                            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true;
                        }
                        return handler;
                    }).AddStandardResilienceHandler(options =>
                        options.Retry.MaxRetryAttempts = 3);

                    services.AddHttpClient<ICalibrationLimitService, CalibrationLimitService>(client =>
                    {
                        string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
                        baseUrl = baseUrl.TrimEnd('/');
                        client.BaseAddress = new Uri(baseUrl);
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
                        options.Retry.MaxRetryAttempts = 3);

                    services.AddHttpClient<ITicketService, TicketService>()
                        .AddStandardResilienceHandler(options =>
                            options.Retry.MaxRetryAttempts = 3);

                    services.AddSingleton<IReportExportService, ReportExportService>();
                    services.AddHttpClient<IMeasurementReportService, MeasurementReportService>(client =>
                    {
                        string baseUrl = context.Configuration["Api:BaseUrl"] ?? "https://localhost:62730";
                        baseUrl = baseUrl.TrimEnd('/');
                        client.BaseAddress = new Uri(baseUrl);
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

                    services.AddSingleton<IDatabaseSearchEngine, SqlDatabaseSearchEngine>();
                    services.AddSingleton<IDatabaseSelectionService, DatabaseSelectionService>();
                    services.AddHostedService<TicketRefreshService>();
                    services.AddHostedService<PlcDataSendService>();
                });
        }
    }
}