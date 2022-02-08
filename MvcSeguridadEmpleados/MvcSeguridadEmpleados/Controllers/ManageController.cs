using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MvcSeguridadEmpleados.Models;
using MvcSeguridadEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcSeguridadEmpleados.Controllers
{
    public class ManageController : Controller
    {
        private RepositoryEmpleado repo;

        public ManageController(RepositoryEmpleado repo) {

            this.repo = repo;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Login(string username,string password)
        {
            Empleado emp = this.repo.FindEmpleado(username, int.Parse(password));

            if (emp != null)
            {

                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                Claim claimName = new Claim(ClaimTypes.Name,username);
                identity.AddClaim(claimName);

                ClaimsPrincipal userPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal);

                return RedirectToAction("PerfilEmpleado", "Empleados");
            }
            else {

                ViewData["MENSAJE"] = "Usuario/Password incorrectos";
            }

            return View();
        }

        public IActionResult ErrorAcceso() {

            return View();        
        }
    }
}
