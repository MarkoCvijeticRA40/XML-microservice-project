using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using ReservationService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AccommodationService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    //    services.AddHostedService<ClientScheduledService>();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
