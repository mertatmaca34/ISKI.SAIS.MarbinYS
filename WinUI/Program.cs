using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections;
using WinUI.Forms;

namespace WinUI
{
    internal static class Program
    {
        /// <summary>  
        ///  The main entry point for the application.  
        /// </summary>  
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,  
            // see https://aka.ms/applicationconfiguration.  
            ApplicationConfiguration.Initialize();

            var splash = new SplashScreenForm();
            splash.Show();

            splash.Refresh();

            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;


                // Ana formu hazýrla ama gösterme  
                var mainForm = services.GetRequiredService<MainForm>();

                // Splash ekraný kapat  
                splash.Close();

                // Ana formu çalýþtýr  
                Application.Run(mainForm);
            }
        }

        static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    services.AddScoped<MainForm>();
                });
    }
}