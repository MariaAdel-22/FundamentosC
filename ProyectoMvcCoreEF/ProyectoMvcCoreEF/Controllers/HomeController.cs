using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMvcCoreEF.Models;

namespace ProyectoMvcCoreEF.Controllers
{
    public class HomeController : Controller
    {
        private ICoche coh;

        public HomeController(ICoche co) {

            this.coh = co;
        }

        public IActionResult Index()
        {
            return View(this.coh);
        }

        [HttpPost]
        public IActionResult Index(string accion) {

            if (accion.ToLower() == "acelerar")
            {
                this.coh.Acelerar();
            }
            else {

                this.coh.Frenar();
            }

            return View(this.coh);
        }
    }
}
