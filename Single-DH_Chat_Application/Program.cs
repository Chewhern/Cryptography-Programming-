using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace EncryptedChatApplication
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
                    webBuilder.UseStartup<Startup>();
                    webBuilder.ConfigureKestrel(serverOptions =>
                    {
                        //Can Put FQDN Domain IP or put Numeric IP (localhost = 0.0.0.0 in its numeric IP format), Port Number is any IP number after ":" for example
                        //"5000" so the full sample access IP for IIS/Kestrel will be 0.0.0.0:5000 for respective application
                        serverOptions.Listen(IPAddress.Parse("0.0.0.0"), (Port_Number),
                            listenOptions =>
                            {
                                listenOptions.UseHttps("Path to cfx file on Windows/Linux/Mac",
                                    "Password");
                            });
                    });
                });
    }
}
