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
           public void ConfigureServices(IServiceCollection services)
            {
                string cadenaSqlServer= @"Data Source=LAPTOP-IVMF1NEK\MSSQLSERVE;Initial Catalog=HOSPITAL CASA;Persist Security Info=True;User ID=SA;Password=MCSD2021";

                DepartamentosContextSQLServer contextSQL = new DepartamentosContextSQLServer(cadenaSqlServer);

            /*Una vez que tenemos la cadena lo que hacemos es decirle que la cadena de conexión será la inyección de dependencia de las clases*/

            services.AddTransient<DepartamentosContextSQLServer>(z => contextSQL);
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
