using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcSeguridadPersonalizada.Controllers
{
    public class ManageController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(string username,string password) {

            if (username.ToLower() == "admin" && password.ToLower() == "admin")
            {

                //Debemos crear una identidad (name y rol) y un principal. Dicha identidad debemos combinarla con la cookie de autentificacion
                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

                /*Todo usuario puede contener una serie de características llamadas Claims. Podemos almacenarlas dentro del USER para usarlas a
                 * lo largo de la APP*/

                Claim claimUserName = new Claim(ClaimTypes.Name, username);
                identity.AddClaim(claimUserName);
                ClaimsPrincipal userPrincipal = new ClaimsPrincipal(identity);

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, new AuthenticationProperties
                {
                    //Le decimos el tiempo que va a mantener la sesión conectada
                    ExpiresUtc = DateTime.Now.AddMinutes(45)
                });

                return RedirectToAction("Perfil", "Usuarios");
            }
            else {
                ViewData["MENSAJE"] = "NO ENTRA";
            }
            return View();
        }
    }
}
