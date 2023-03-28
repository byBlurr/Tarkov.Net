using ElectronNET.API;
using Microsoft.AspNetCore.Hosting;

namespace TarkovTracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseElectron(args); // <-- add this
                    webBuilder.UseStartup<Startup>();
                });
    }
}