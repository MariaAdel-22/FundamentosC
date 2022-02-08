using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeguridadPersonalizada.Filters
{
    public class AuthorizeUsersAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            //Los usuarios son almacenados DENTRO de HttpContext y dentro de User
            //Un usuario está compuesto por una identidad y un principal donde podemos saber el nombre del usuario o si está autenticado
            var user = context.HttpContext.User;

            if (user.Identity.IsAuthenticated == false) {

                //Necesitamos realizar la redirección para llevarnos la petición a Login del controlador Manage
                RouteValueDictionary rutalogin = new RouteValueDictionary(new
                {
                    controller="Manage",
                    action="Login"
                });

                RedirectToRouteResult result = new RedirectToRouteResult(rutalogin);
                context.Result = result;
            }
        }
    }
}
