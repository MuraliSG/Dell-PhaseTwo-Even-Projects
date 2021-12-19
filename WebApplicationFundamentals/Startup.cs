using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationFundamentals
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // this method helps in adding the middlewares, dependencies, configurations and so on...
        public void ConfigureServices(IServiceCollection services)
        {
            // AddRazorpages is a middleware
            //services.AddRazorPages();
            // adding a middleware for configuring MVC
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // this method helps in uses already added middlewares in request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            //DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
            //defaultFilesOptions.DefaultFileNames.Clear();
            //defaultFilesOptions.DefaultFileNames.Add("Dashboard.html");
            //defaultFilesOptions.DefaultFileNames.Add("Home.html");
            ////UseDefaultFiles is one of the middle ware
            //app.UseDefaultFiles(defaultFilesOptions);
            //app.UseDefaultFiles();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            // use MVC middleware /end point for configuring routes 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute
                (
                    name: "Default", 
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                 );
            });
        }
    }
}
