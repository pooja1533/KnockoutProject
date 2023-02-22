using DataModel;
using DataModel.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Repository;
using RepositoryInterface;
using ServiceInterfaces;
using Services;

namespace KnockoutProject
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
            services.AddMvc(options=>options.EnableEndpointRouting=false);

            var connectionstring = Configuration.GetConnectionString("myconn");
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionstring));

            //services
            services.AddScoped<IUserService,UserService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<IHotelService, HotelService>();
            services.AddScoped<ITourService, TourService>();
            //Repository
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IBaseRepository, BaseRepository>();
            services.AddScoped<ILocationRepository, LocationRepository>();
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<ITourRepository, TourRepository>();
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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            //app.UseMvcWithDefaultRoute();

            //app.UseRouting();

            //app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapRazorPages();
            //});
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Login}/{action=Login}/{id?}");
            });


        }
    }
}
