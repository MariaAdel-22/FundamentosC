using MvcEmpleadosReto.Models;
using MvcEmpleadosReto.Repositories;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEmpleadosReto.App_Start
{
    public class IoCConfigurationNinject:NinjectModule
    {
        private static void RegisterServices(IKernel kernel)
        {
            // Usar la clase NumberRepository cuando se encuentre
            // la interface INumberRepository
            kernel.Bind<IRepository>().To<RepositoryEmpleados>();
        }

        public override void Load()
        {
            Bind<IRepository>().To<RepositoryEmpleados>();
        }
    }
}