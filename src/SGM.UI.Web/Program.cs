using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using SGM.Infrastructure.Data;

namespace SGM.UI.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
            //var host = new BuildWebHost(args);

            //using (var scope = host.Services.CreateScope())
            //{
            //    var Services = scope.ServiceProvider;
            //    try
            //    {
            //        var context = Services.GetRequiredService<Context>();
            //        DbInitializer.Initialize(context);
            //    }
            //    catch (Exception)
            //    {

            //        var logger = Services.GetRequiredService<ILogger<Program>>();
            //    }
            //}
            //host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
