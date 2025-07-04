using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinUI.Forms;
using WinUI.Pages;
using WinUI.Services;

namespace WinUI
{
    internal static class Program
    {
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
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            var mainForm = services.GetRequiredService<MainForm>();

            splash.Invoke(() => splash.Close());
            splashThread.Join();

            Application.Run(mainForm);
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
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
                        string baseUrl = context.Configuration["Api:BaseUrl"] ?? "http://localhost:62730";
                        if (!baseUrl.EndsWith('/')) baseUrl += "/";
                        client.BaseAddress = new Uri(baseUrl);
                    });
                });
    }
}
