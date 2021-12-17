using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMvcDatosOld.Models;

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

        public IActionResult VistaCoche() {

            Coche coche = new Coche();

            coche.Marca = "Ford";
            coche.Modelo = "Fiesta";

            return View(coche);
        }
    }
}
