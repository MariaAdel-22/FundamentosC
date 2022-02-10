using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MvcSeguridadDoctores.Models;
using MvcSeguridadDoctores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcSeguridadDoctores.Controllers
{
    public class ManageController : Controller
    {
        private RepositoryEnfermos repo;

        public ManageController(RepositoryEnfermos repo) {

            this.repo = repo;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Login(string nombre,string idDoctor) {

            Doctor enf = this.repo.FindDoctor(nombre,idDoctor);

            if (enf != null)
            {

                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

                Claim claimName = new Claim(ClaimTypes.Name, nombre);
                Claim claimID = new Claim(ClaimTypes.NameIdentifier, idDoctor);

                identity.AddClaim(claimName);
                identity.AddClaim(claimID);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                string controller = TempData["controller"].ToString();
                string action = TempData["action"].ToString();

                return RedirectToAction(action, controller);

            }
            else {
                return RedirectToAction("Login", "Manage");
            }

        }

    }
}
