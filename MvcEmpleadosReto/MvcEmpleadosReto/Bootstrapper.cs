using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;
using System;

namespace MvcEmpleadosReto
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }
    }
}