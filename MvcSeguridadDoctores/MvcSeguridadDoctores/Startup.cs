using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcSeguridadDoctores.Data;
using MvcSeguridadDoctores.Policies;
using MvcSeguridadDoctores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeguridadDoctores
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
            //Creamos una politica de acceso por ROLES
            services.AddAuthorization(options =>
            {
                options.AddPolicy("PermisosElevados", policy => 
                policy.RequireRole("Cardiolog�a","Neurolog�a"));

                options.AddPolicy("AdminOnly",
                    policy => policy.RequireClaim("Administrador"));

                options.AddPolicy("SoloDoctoresRicos",
                    policy => policy.Requirements.Add(new OverSalarioRequirement()));
            });


            string cadena = this.Configuration.GetConnectionString("CadenaHospitalCasa");
            services.AddTransient<RepositoryEnfermos>();
            services.AddDbContext<EnfermosContext>(options => options.UseSqlServer(cadena));

            services.AddAuthentication(options =>
            {
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie(
                CookieAuthenticationDefaults.AuthenticationScheme,
                config => {
                    config.AccessDeniedPath = "/Manage/ErrorAcceso";
                }
                );

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddSingleton<ITempDataProvider, CookieTempDataProvider>();

            services.AddControllersWithViews
                (options => options.EnableEndpointRouting = false).AddSessionStateTempDataProvider();
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

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(

                    name: "Default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                    );
            });
           /* app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });*/
        }
    }
}
