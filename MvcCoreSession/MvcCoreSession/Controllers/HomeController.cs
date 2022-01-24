using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCoreSession.Helpers;
using MvcCoreSession.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult EjemploSession(string accion) {

            if (accion == "almacenar") {

                Persona per = new Persona();

                per.Nombre = "Alumno";
                per.Edad = 22;
                per.Hora = DateTime.Now.ToLongTimeString();

                //Mediante el helper convertimos el obj persona a Byte[]
                byte[] data = HelperSession.ObjectToByte(per);

                //Ahora almacenamos el objeto a nivel de byte en session
                HttpContext.Session.Set("Persona", data);

                ViewData["MENSAJE"] = "Datos almacenados en Session";

            } else if (accion == "mostrar") {

                //Extraemos la informacion de byte[] session
                byte[] data = HttpContext.Session.Get("Persona");

                //Convertimos los byte[] a objeto
                Persona per = (Persona)HelperSession.ByteToObject(data);

                ViewData["Persona"] = per.Nombre + ", Edad: " + per.Edad;
                ViewData["Hora"] = per.Hora;
            }

            return View();
        }

        public IActionResult ColeccionSession(string accion) {

            if (accion == "almacenar") {

                List<Persona> personas = new List<Persona>
                {
                    new Persona{ Nombre= "Antonia",Edad=46, Hora=DateTime.Now.ToLongDateString()},
                    new Persona{ Nombre= "Antonia",Edad=46, Hora=DateTime.Now.ToLongDateString()},
                    new Persona{ Nombre= "Antonia",Edad=46, Hora=DateTime.Now.ToLongDateString()}
                };

                byte[] data = HelperSession.ObjectToByte(personas);

                HttpContext.Session.Set("PERSONAS", data);
                ViewData["mensaje"] = "Datos almacenados";

                return View();

            } else if (accion == "mostrar") {

                byte[] data = HttpContext.Session.Get("PERSONAS");

                List<Persona> personas = (List<Persona>)HelperSession.ByteToObject(data);

                return View(personas);
            }

            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
