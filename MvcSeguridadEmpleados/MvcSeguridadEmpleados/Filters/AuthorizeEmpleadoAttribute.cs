using Microsoft.AspNetCore.Session;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MvcSeguridadEmpleados.Filters
{
    public class AuthorizeEmpleadoAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //Dentro de los context tenemos una información de las rutas generadas
            //Dicha información siempre será la misma aunque pueden cambiar elementos
            //La información ciene dentro de RouteData, contiene una coleccion llamada values con todos los posibles en la ruta

            //Podemos recoger parámetros de la ruta también
            //string ID= context.RouteData.Values["id"].ToString();

            var user = context.HttpContext.User;

            //Si el usuario NO está autentificado
            if (user.Identity.IsAuthenticated == false)
            {
                string controller = context.RouteData.Values["controller"].ToString();
                string action = context.RouteData.Values["action"].ToString();

                //Buscamos el proveedor de tempdata que estamos utilizando en startup
                ITempDataProvider provider = context.HttpContext.RequestServices.GetService(typeof(ITempDataProvider)) as ITempDataProvider;

                //Ahora debemos recuperar el objeto TEMPDATA que está utilizando el Controller

                var TempData = provider.LoadTempData(context.HttpContext);

                //Almacenamos la información como siempre
                TempData["CONTROLLER"] = controller;
                TempData["ACTION"] = action;

                //Ahora almacenamos el tempdata dentro del provider
                provider.SaveTempData(context.HttpContext, TempData);

                context.Result = this.GetRouteRedirect("Manage", "Login");
            }
            else {
                //En esta zona debemos validar si role por oficio

                if (user.IsInRole("PRESIDENTE") == false &&
                    (user.IsInRole("DIRECTOR") == false) &&
                    (user.IsInRole("ANALISTA") == false)) {

                    context.Result = this.GetRouteRedirect("Manage", "ErrorAcceso");
                }
            }
        }

        //Es un método para crear las rutas (a la que deba redireccionar) de manera dinámica
        private RedirectToRouteResult GetRouteRedirect(string controller, string action) {

            RouteValueDictionary ruta = new RouteValueDictionary(new
            {
                controller = controller,
                action = action
            });

            RedirectToRouteResult result = new RedirectToRouteResult(ruta);
            return result;
        }
    }
}
