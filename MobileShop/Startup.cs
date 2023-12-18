using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MobileShop.Data;
using MobileShop.Data.Interfaces;
using MobileShop.Data.Models;
using MobileShop.Data.Repositories;

namespace MobileShop
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;
        public Startup(IHostingEnvironment hostingEnvironment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = _configurationRoot.GetConnectionString("Sqlite");
            services.AddDbContext<AppDbContext>(optionsAction =>
                optionsAction.UseSqlite(connectionString));

            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IBannerRepository, BannerRepository>();

            services.AddMvc();
            services.AddDistributedMemoryCache();
            services.AddSession();
            services.AddSingleton<IActionContextAccessor, ActionContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //app.UseExceptionHandler("/Home/Error");
            }

            app.UseSession();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            


            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Product}/{action=Index}/{id?}");
                routes.MapAreaRoute(
                  name: "areaAdmin",
                  areaName: "Admin",
                  template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
