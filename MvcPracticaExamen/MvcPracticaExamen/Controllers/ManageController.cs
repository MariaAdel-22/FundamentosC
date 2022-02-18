using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcPracticaExamen.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string user,string psswd) {

            if (user == "admin" && psswd == "admin")
            {

                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

                Claim ClName = new Claim(ClaimTypes.Name, user);
                Claim CLPass = new Claim(ClaimTypes.NameIdentifier, psswd);

                identity.AddClaim(ClName);
                identity.AddClaim(CLPass);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                string controller = TempData["controller"].ToString();
                string action = TempData["action"].ToString();
                int id =int.Parse(TempData["id"].ToString());

                return RedirectToAction(action, controller, new {id=id});
            }
            else {

                return RedirectToAction("Login","Manage");
            }
        }
    }
}
