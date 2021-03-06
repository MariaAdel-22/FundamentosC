using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcPracticaExamen2.Data;
using MvcPracticaExamen2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen2
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
            //Conexion BBDD
            string cadena = this.Configuration.GetConnectionString("Cadena");
            services.AddTransient<RepositoryDoctor>();
            services.AddDbContext<DoctorContext>(options => options.UseSqlServer(cadena));


            //Configurar Session
            services.AddDistributedMemoryCache();
            services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(45));

            //Configurar Authentication (cookies)

            services.AddAuthentication(option =>
            {

                option.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                option.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            }).AddCookie();


            //Configurar TempDataProvider (Filters)

            services.AddSingleton<ITempDataProvider>();

            //Por si usamos cookies en el filter
            services.AddSingleton<CookieTempDataProvider>();

            //A?adir las Policies

            services.AddAuthorization(option =>
            {
                option.AddPolicy("AccesoEspecial", policy => policy.RequireClaim("Especial"));
                option.AddPolicy("AdminDefinitivo", policy => policy.RequireClaim("Administrador"));
                option.AddPolicy("PermisosEspDef",policy =>
                {
                    //Debe cumplirse los dos claim
                    policy.RequireClaim("Especial").RequireClaim("Administrador");
                 });
            });

            services.AddControllersWithViews(option => option.EnableEndpointRouting = false).AddCookieTempDataProvider();
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

            app.UseMvc(route =>
            {

                route.MapRoute(

                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}"
                );
            });
           
        }
    }
}
