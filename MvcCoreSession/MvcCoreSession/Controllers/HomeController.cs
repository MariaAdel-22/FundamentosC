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
                string data = HelperSession.SerializeObject(per);

                //Ahora almacenamos el objeto a nivel de byte en session
                HttpContext.Session.SetString("Persona", data);

                ViewData["MENSAJE"] = "Datos almacenados en Session";

            } else if (accion == "mostrar") {

                //Extraemos la informacion de byte[] session
                string data = HttpContext.Session.GetString("Persona");

                //Convertimos los byte[] a objeto
                Persona per = (Persona)HelperSession.DeserializeObject(data, typeof(Persona));

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

                string jsonData = HelperSession.SerializeObject(personas);
                HttpContext.Session.SetString("PERSONAS", jsonData);

                List<int> numeros = new List<int> { 4, 5, 6, 7, 8, 8, 3 };

                string jsonNumeros = HelperSession.SerializeObject(numeros);
                HttpContext.Session.SetString("NUMEROS", jsonNumeros);

                ViewData["MENSAJE"] = "datos almacenados";

            } else if (accion == "mostrar") {

                string data = HttpContext.Session.GetString("PERSONAS");
                List<Persona> personas = (List<Persona>)HelperSession.DeserializeObject(data, typeof(List<Persona>));

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
