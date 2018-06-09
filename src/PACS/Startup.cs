﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PACS.DB;
using PACS.Models;

namespace PACS
{
    public class Startup
    {
        IConfigurationRoot Configuration;
        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(Configuration["Data:ConnectionStrings"]));
            services.AddTransient<IGymMemberRepo, EFMemberRepository>();
            services.AddTransient<IGymCardRepo, EFCardsRepository>();
            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: null, template: "{kind}/Page{page:int}", defaults: new { controller = "Home", action = "Index"});
                routes.MapRoute(name: null, template: "Page{page:int}", defaults: new { controller = "Home", action = "Index", page = 1 });
                routes.MapRoute(name: null, template: "kind", defaults: new { controller = "Home", action = "Index", page = 1 });
                routes.MapRoute(name:null,template:"",defaults:new { controller = "Home", action = "Index", page = 1});
                routes.MapRoute(name:null,template:"{controller}/{action}/{id?}");
                
            });
            //SeedData.EnsurePopulated(app);
        }
    }
}
