using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Authorization;

namespace MvcSeguridadDoctores.Filters
{
    public class AuthorizeEnfermosAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.User;

            if (user.Identity.IsAuthenticated == false)
            {

                string controller = context.RouteData.Values["controller"].ToString();
                string action = context.RouteData.Values["action"].ToString();

                ITempDataProvider provider = context.HttpContext.RequestServices.GetService(typeof(ITempDataProvider)) as ITempDataProvider;

                var TempData = provider.LoadTempData(context.HttpContext);

                TempData["controller"] = controller;
                TempData["action"] = action;

                provider.SaveTempData(context.HttpContext, TempData);
                context.Result = this.GetRutas(controller, action);
            }
            else {

                context.Result = this.GetRutas("Manage", "Login");
            }
        }

        private RedirectToRouteResult GetRutas(string controller,string action) {

            RouteValueDictionary ruta = new RouteValueDictionary(new
            {
                controller=controller,
                action=action
            });

            RedirectToRouteResult result = new RedirectToRouteResult(ruta);
            return result;
        }
    }
}
