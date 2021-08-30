using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace webcoreemptytemp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IDisplay,Display>();
             
            services.AddMvc().AddRazorPagesOptions(options =>
            {
                options.Conventions.AddPageRoute("/MyRazor", "{*url}");
            });

            services.AddMvc();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILoggerFactory loggerFactory,IDisplay display)
        {

            //middleware - log
            var logger = loggerFactory.CreateLogger("Middleware Timer check demo..");
            app.Use(async (context, next) =>
            {
                var timer = System.Diagnostics.Stopwatch.StartNew();
                logger.LogInformation($"Core Request in {env.EnvironmentName} environment");
                await next();
                logger.LogInformation($"Core Request finished in {timer.ElapsedMilliseconds} milliseconds");
            });

            //app.UseFileServer();

                        app.UseWelcomePage(new WelcomePageOptions
            {
                Path = "/Welcome"
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            //app.Run(async (context) => {
            //   // throw new Exception("Throwin the exception to check the page..");

            //    });

            //app.Run(async (context) => {

            //    await context.Response.WriteAsync("Hey there!" + env.WebRootPath);
            //});
            app.UseEndpoints(endpoints =>
            { 
                        endpoints.MapGet("/", async context =>
                        {
                            await context.Response.WriteAsync(display.disp() );
                        });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/"
                    );
                //endpoints.MapRazorPages();

            });
    }
}
}
