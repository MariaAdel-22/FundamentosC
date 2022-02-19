using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MvcPracticaExamen2.Models;
using MvcPracticaExamen2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcPracticaExamen2.Controllers
{
    public class ManageController : Controller
    {
        private RepositoryDoctor repo;

        public ManageController(RepositoryDoctor repo) {

            this.repo = repo;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username,string psswd) {

            Doctor doc = this.repo.FindDoctor(int.Parse(psswd));

            if (doc != null)
            {

                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

                Claim ClName = new Claim(ClaimTypes.Name, username);
                Claim ClPss = new Claim(ClaimTypes.NameIdentifier, psswd);

                identity.AddClaim(ClName);
                identity.AddClaim(ClPss);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                string controller = TempData["controller"].ToString();
                string action = TempData["action"].ToString();
                string id = TempData["id"].ToString();

                return RedirectToAction(action, controller, new { id = id });
            }
            else {

                return RedirectToAction("Login","Manage");
            }
        }
    }
}
