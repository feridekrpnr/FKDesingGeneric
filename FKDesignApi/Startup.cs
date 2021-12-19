using FKDesignDataAccess;
using FKDesignDataAccess.Repositories;
using FKDesignEntities.Models;
using FKDesignEntities.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FKDesignApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {  services.AddRazorPages();
            services.AddDbContext<FKDesignDBContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<ISettingRepository, SettingRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IUserRepository, UserRepository>();
            //services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<FKDesignDBContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //bir yerde bu oluşuyor ve hata buna geliyor FKDesignDBContext
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}