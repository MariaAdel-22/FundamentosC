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

        //DEBE TENER SIEMPER UN MÉTODO GET LA VISTA AUNQUE USE EL POST (POR ESO SOBRECARGAMOS EL MÉTODO ABAJO PERO DICIÉNDOLE QUE TENDRÁ EL ATRIBUTO POST)
        public IActionResult VistaPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult VistaPost(Persona persona) {

            return View(persona);
        }

        //GET para la vista VistaNumeroDoble

        public IActionResult VistaNumeroDoble(System.Nullable<int> numero,string dato) {

            //Si dato fuera opcional, podemos preguntar por lo más comun, si es null para saber si lo ha recibido o no

            if (dato == null) { 
            
                //Sé que dato no ha recibido nada
            }

            //SI numero fuera opcional, solo puedo preguntar por el valor 0, pero está la cosa de que 0 puede ser un valor que quiero recibi. Por ello usamos el tipo System.Nullable<primitivo>(int?)

            if (numero != null)
            {

                int doble = numero.Value * 2;

                ViewBag.Doble = "El doble del número es: " + doble;
            }
            else {

                //El numero es null
                ViewBag.Doble = "No hemos recibido ningún NUMERO";
            }

            return View();
        }
    }
}
