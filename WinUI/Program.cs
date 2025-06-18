using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WinUI.Forms;
using WinUI.Pages;

namespace WinUI
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            // 1. Splash ekran� ayr� thread'de ba�lat
            SplashScreenForm splash = new SplashScreenForm();
            var splashThread = new Thread(() =>
            {
                Application.Run(splash); // kendi UI loop'u
            });
            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            // 2. Main host'u haz�rla (bu biraz zaman al�r)
            var host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;

            // 3. Ana formu haz�rla
            var mainForm = services.GetRequiredService<MainForm>();

            // 4. Splash kapanacak, thread de bitirilecek
            splash.Invoke(() => splash.Close()); // UI thread'inde kapat
            splashThread.Join(); // splash kapanana kadar bekle

            // 5. Ana formu ba�lat
            Application.Run(mainForm);
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<MainForm>();
                    services.AddSingleton<HomePage>();
                });
    }
}
