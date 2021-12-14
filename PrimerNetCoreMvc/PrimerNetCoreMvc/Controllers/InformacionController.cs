using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerNetCoreMvc.Controllers
{
    public class InformacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ControladorVista() {

            ViewData["Nombre"] = "Alumno";
            ViewData["Edad"] = 32;

            return View();
        }
    }
}
