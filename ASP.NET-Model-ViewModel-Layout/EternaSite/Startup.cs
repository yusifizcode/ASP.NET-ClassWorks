using EternaSite.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EternaSite
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(@"Server=DESKTOP-1TG370G;Database=Eterna;Trusted_Connection=TRUE");
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
            endpoints.MapControllerRoute(
                "default",
                "{controller=home}/{action=index}/{id?}"
                );
             
            endpoints.MapControllerRoute(
                "about",
                "about",
                defaults: new { controller = "Home", action = "About" }
                );

            endpoints.MapControllerRoute(
                "services",
                "services",
                defaults: new { controller = "Home", action = "Services" }
                );

            endpoints.MapControllerRoute(
                "team",
                "team",
                defaults: new { controller = "Home", action = "Team" }
                );

            endpoints.MapControllerRoute(
                "pricing",
                "pricing",
                defaults: new { controller = "Home", action = "Pricing" }
                );

            endpoints.MapControllerRoute(
                "portfolio",
                "portfolio",
                defaults: new { controller = "Portfolio", action = "Portfolio" }
                );

            endpoints.MapControllerRoute(
                "blog",
                "blog",
                defaults: new { controller = "Blog", action = "Blog" }
                );

            endpoints.MapControllerRoute(
                "contact",
                "contact",
                defaults: new { controller = "Contact", action = "Contact" }
                );
            });
        }
    }
}
