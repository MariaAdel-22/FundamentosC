using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen.Filters
{
    public class AuthorizeAdminAttribute : AuthorizeAttribute,IAuthorizationFilter
    {

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            
            var user = context.HttpContext.User;

            string controller = context.RouteData.Values["controller"].ToString();
            string action = context.RouteData.Values["action"].ToString();
            int id = 0;

            if (context.RouteData.Values.ContainsKey("id")) { 
                
                id = int.Parse(context.RouteData.Values["id"].ToString());
            }
           
            ITempDataProvider data = context.HttpContext.RequestServices.GetService(typeof(ITempDataProvider)) as ITempDataProvider;

            var TempData = data.LoadTempData(context.HttpContext);

            TempData["controller"] = controller;
            TempData["action"] = action;
            TempData["id"] = id;

            data.SaveTempData(context.HttpContext, TempData);

            if (user.Identity.IsAuthenticated == false)
            {
  
                context.Result = this.GetRutas("Manage", "Login");
            }

        }
        private RedirectToRouteResult GetRutas(string controller,string action) {

            RouteValueDictionary ruta = new RouteValueDictionary(new
            {
                controller=controller,
                action=action
            });

            RedirectToRouteResult rut = new RedirectToRouteResult(ruta);

            return rut;
        }
    }
}
