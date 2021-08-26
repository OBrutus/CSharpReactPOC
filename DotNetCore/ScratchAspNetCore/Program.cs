using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace ScratchAspNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            const string URL = "localhost";
            Console.WriteLine("Hello World!\n \tThis is console app");
            //CreateDefaultBuilder(args).Build().Run();
            //var host = 
                new HostBuilder().UseEnvironment("dev").Build().Run();
                //.UseUrls($"http://{URL}:5000")
                //.ConfigureServices(services =>
                //    {

                //    })
                //.UseStartup<Startup>()
                //.Build();
                //.UseContentRoot(System.IO.Directory.GetCurrentDirectory())
                //.UseWebRoot("Content")
                //.UseStartup<Startup>()
                //.Build();

            //host.Start();
        }
    }
}
