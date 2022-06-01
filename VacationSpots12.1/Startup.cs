using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VacationSpots12._1.Services;
using VacationSpots12._1.Models;


namespace VacationSpots12._1
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
            services.AddControllersWithViews();
            //services.AddSingleton<IData, Data>(); //in memory list
            services.AddScoped <IData, DBData>();    //database 

            //connects app to the DB
            //services.AddDbContext<VacationContext>(options => options.UseSqlite("Data Source = Vacations.db"));  //sqlite 
            services.AddDbContext<VacationContext>(options => options.UseSqlServer(@"Server = VSFULLSTACK\SQLEXPRESS;Database=EmpSytemdb;Trusted_Connection=true;MultipleActiveResultSets=True")); //sqlserver
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(VacationContext vacationContext, IApplicationBuilder app, IWebHostEnvironment env)
        {

            //vacationContext.Database.EnsureDeleted();
            //checks if DB is alive
            vacationContext.Database.EnsureCreated();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();  //detailed error page
            }
            else if (env.IsProduction())
            {
                app.UseExceptionHandler("/Home/Error"); //create this page in wwwroot folder
            }
            app.UseStaticFiles();

            app.UseRouting();

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
