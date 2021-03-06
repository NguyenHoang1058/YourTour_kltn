using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using YourTour.Models.db;
using YourTour.Service;

namespace YourTour
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
        {
            services.AddDbContext<YourTourContext>(opt => 
                opt.UseSqlServer(Configuration.GetConnectionString("YourTourContext")));
            //
            //services.AddDatabaseDeveloperPageExceptionFilter();
            //services.AddControllersWithViews();
            services.AddSession();
            services.AddScoped<TourService>();
            services.AddScoped<TravelService>();
            services.AddScoped<DattourService>();
            services.AddScoped<StaffService>();
            services.AddScoped<LocationService>();
            services.AddScoped<HoaDonService>();
            services.AddScoped<StatisticService>();
            services.AddScoped<CommonService>();
            services.AddScoped<AdminService>();
            services.AddScoped<KinhNghiemDuLichService>();
            services.AddScoped<LienHeService>();
            services.AddScoped<TinTucService>();
            services.AddScoped<DiaDiemService>();
            services.AddScoped<KhachSanService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseSession();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
