using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace UofLMentorshipProgram
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while(!Debugger.IsAttached) {
                
            }
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((hostingContext, config) => {
                    config.Sources.Clear();

                    var env = hostingContext.HostingEnvironment.EnvironmentName;

                    config.AddJsonFile("Configs/appsettings.json", optional: true, reloadOnChange: true)
                        .AddJsonFile($"Config/appsettings.{env}.json", optional: true, reloadOnChange: true);

                    config.AddEnvironmentVariables(prefix: "ULMentor_");
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
