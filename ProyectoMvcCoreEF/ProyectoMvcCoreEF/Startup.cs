using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMvcCoreEF.Models;
using ProyectoMvcCoreEF.Data;

namespace ProyectoMvcCoreEF
{
    public class Startup
    {
        public Startup(IConfiguration configuration) {

            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

           public void ConfigureServices(IServiceCollection services)
            {
            String cadenaMySql = this.Configuration.GetConnectionString("cadenahospitalmysql");

            DepartamentosContextMySQL contextMySQL = new DepartamentosContextMySQL(cadenaMySql);
            services.AddTransient<IDepartamentosContext>(x => contextMySQL);

            services.AddSingleton<ICoche, Coche>();
            services.AddControllersWithViews();
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
                        name: "default",
                        pattern: "{controller=Home}/{action=Index}");
                });
            }
        }

}
