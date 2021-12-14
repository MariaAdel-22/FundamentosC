using Microsoft.AspNetCore.Mvc;
using PrimerNetCoreMvc.Models;
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

            Persona person = new Persona();

            person.Nombre = "Persona Model";
            person.Edad = 44;
            person.Email = "personamodel@gmail.com";

            return View(person);
        }

        public IActionResult VistaControllerGet(string app,int version) {

            ViewData["DATOS"] = app + ", Version: " + version;

            return View();
        }

    }
}
