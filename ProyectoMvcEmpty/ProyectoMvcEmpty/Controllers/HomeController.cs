using Microsoft.AspNetCore.Mvc;
using ProyectoMvcEmpty.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcEmpty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contenido() {

            return View();
        }

        public IActionResult VistaPersona() {

            Persona pers = new Persona();
            pers.nombre = "Antonio";
            pers.Edad = 65;
            pers.Email = "persona@gmail.com";

            return View(pers);
        }
    }
}
