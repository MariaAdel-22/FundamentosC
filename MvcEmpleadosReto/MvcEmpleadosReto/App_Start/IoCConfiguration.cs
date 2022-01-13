using Autofac;
using Autofac.Integration.Mvc;
using MvcEmpleadosReto.Data;
using MvcEmpleadosReto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace MvcEmpleadosReto.App_Start
{
    public class IoCConfiguration
    {
        public static void ConfigureDependencies() {

            ContainerBuilder builder = new ContainerBuilder();
            builder.Register(z => new EmpleadosContext()).InstancePerRequest();

            builder.RegisterType<RepositoryEmpleados>().InstancePerRequest();

            //Como estamos en el entorno MVC debemos también registrar todos los controladores
            //Le vamos a decir que registre todo
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            IContainer container = builder.Build();

            //Le indicamos a la app que usaremos este contenedor para las dependencias
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}