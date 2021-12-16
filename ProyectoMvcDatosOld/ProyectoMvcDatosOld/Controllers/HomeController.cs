using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcDatosOld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Cambio = 0;
            return View();
        }

        public IActionResult VistaPagina1() {

            return View();
        }
    }
}
