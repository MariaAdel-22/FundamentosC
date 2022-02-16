using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using MvcCoreLinqXML.Filters;
using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcCoreLinqXML.Controllers
{
    public class CursosController : Controller
    {
        private RepositoryCursos repo;

        public CursosController(RepositoryCursos repo) {

            this.repo = repo;
        }

        public IActionResult Index()
        {
            Curso curso = this.repo.GetUsuarios();

            return View(curso);
        
        }

        [AuthorizeAlumnos]
        public IActionResult Perfil() {

            Usuario usu = this.repo.GetUsuario(HttpContext.User.FindFirst("username").Value,HttpContext.User.FindFirst("password").Value);

            return View(usu);
        }

        public IActionResult Login() {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string username,string password) {

            Usuario usu = this.repo.GetUsuario(username, password);

            if (usu != null)
            {

                ClaimsIdentity identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);

                Claim userName = new Claim("username", username);
                Claim userPass = new Claim("password", password);

                identity.AddClaim(userName);
                identity.AddClaim(userPass);

                ClaimsPrincipal principal = new ClaimsPrincipal(identity);


                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                return RedirectToAction("Perfil");
            }
            else
            {

                return RedirectToAction("Login");
            }

        }

    }
}
