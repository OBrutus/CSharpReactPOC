using EkamArtMBProj.Data;
using EkamArtMBProj.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EkamArtMBProj
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        //DI
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPaintingRepo, PaintingRepo>();
            services.AddScoped<ICategoryRepo, CategoryRepo>();
            services.AddControllersWithViews();
            services.AddDefaultIdentity<IdentityUser>().AddEntityFrameworkStores<EkamArtMBProjContext>();
            services.AddDbContext<PaintingDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
                                                                    .EnableSensitiveDataLogging());
            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddHttpContextAccessor();
            services.AddSession();

            services.AddAuthentication()
                  .AddGoogle(opts =>
                  {
                      IConfigurationSection configurationSection =
                      Configuration.GetSection("Authentication:Google");
                      opts.ClientId = configurationSection["ClientId"];
                      opts.ClientSecret = configurationSection["ClientSecret"]; 
                      opts.SignInScheme = IdentityConstants.ExternalScheme;
                  });
        }

        // This method g ets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseFileServer();
            app.UseSession();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
