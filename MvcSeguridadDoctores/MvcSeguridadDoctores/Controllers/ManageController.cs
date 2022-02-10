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

        public IActionResult ErrorAcceso() {

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
                Claim claimRol = new Claim(ClaimTypes.Role, enf.Especialidad);
                Claim claimSalario = new Claim("Salario", enf.Salario.ToString());

                identity.AddClaim(claimName);
                identity.AddClaim(claimID);
                identity.AddClaim(claimRol);
                identity.AddClaim(claimSalario);

                //DOCTOR CABEZA D. TENDRÁ UN CLAIM DE ADMINISTRADOR

                if (enf.CodigoDoctor == 386) {

                    identity.AddClaim(new Claim("Administrador", "Todo me vale"));
                }

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                string controller = TempData["controller"].ToString();
                string action = TempData["action"].ToString();
                string id = TempData["id"].ToString();

                return RedirectToAction(action, controller,new { id=id});

            }
            else {
                return RedirectToAction("Login", "Manage");
            }

        }

    }
}
