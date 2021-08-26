using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScratchAspNetCore
{
    class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc(route =>route.MapRoute("default", "{controller=Home}/{action=Index  }/{id?}"));

            app.Run(MyMiddleware);

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync(" in Use : Hello World From 1st Middleware\n");
                await next();
            });

            // the following will never be executed
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync(" in Run : Hello World From 2nd Middleware\n");
            });
        }
        public async Task MyMiddleware(HttpContext context)
        {
            await context.Response.WriteAsync("Hi, from custom  middleware 0");
        }

    }
}
