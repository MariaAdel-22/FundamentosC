using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcNetCoreClienteWCF.Services;
using ReferenceCatrasto;
using ServiceCochesClass;
using ServicioClientesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF
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
            ReferenceNumberConversion.NumberConversionSoapTypeClient clientNumberConversion =
            new ReferenceNumberConversion.NumberConversionSoapTypeClient(ReferenceNumberConversion.NumberConversionSoapTypeClient.
            EndpointConfiguration.NumberConversionSoap);


           CochesContractClient cochesClient = new CochesContractClient
             (CochesContractClient.EndpointConfiguration.BasicHttpBinding_ICochesContract);

            services.AddSingleton<CochesContractClient>(x =>cochesClient);

            services.AddSingleton<ServiceCoches>();

            ClientesContractClient clientesClient = 
                new ClientesContractClient(ClientesContractClient.EndpointConfiguration.BasicHttpBinding_IClientesContract);

            services.AddSingleton<ClientesContractClient>(x => clientesClient);
            services.AddSingleton<ServiceClientesID>();

            services.AddSingleton<ServiceNumberConversion>();
            services.AddSingleton<CallejerodelasedeelectrónicadelcatastroSoapClient>();
            services.AddSingleton<ServiceCatastro>();
            services.AddTransient<ServiceCountries>();
            services.AddTransient<ServiceMetodosVarios>();
            services.AddControllersWithViews();
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
