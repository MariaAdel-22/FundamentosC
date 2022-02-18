using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcPracticaExamen.Extensions;
using MvcPracticaExamen.Filters;
using MvcPracticaExamen.Models;
using MvcPracticaExamen.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen.Controllers
{
    public class PeliculasController : Controller
    {
        private PeliculasRepository repo;

        public PeliculasController(PeliculasRepository repo) {

            this.repo = repo;
        }

        public IActionResult CargarPeliculasGenero(int idGenero)
        {
            List<Pelicula> Peliculas = this.repo.GetPeliculasGenero(idGenero);

            return View(Peliculas);
        }

        public IActionResult CargarPeliculasNac(int idNac) {

            List<Pelicula> Peliculas = this.repo.GetNacionalidades(idNac);

            return View(Peliculas);
        }

        public IActionResult _DetallePeliculaG(string id) {

            Pelicula pel = this.repo.GetPeliculaGenero(int.Parse(id));

            return PartialView("_DetallePeliculaG", pel);
        }

        public IActionResult _DetallePeliculaN(string id) {

            Pelicula pel = this.repo.GetPeliculaNacionalidad(int.Parse(id));

            return PartialView("_DetallePeliculaN", pel);
        }

        [HttpPost]
        public JsonResult InsertarCarrito(string idPelicula,string cantidad,int can) {

            Dictionary<string, string> PeliCantidad;


            if (HttpContext.Session.GetString("PeliCantidad") == null)
            {

                PeliCantidad = new Dictionary<string, string>();
            }
            else
            {
                PeliCantidad = HttpContext.Session.DeserializeObject<Dictionary<string, string>>("PeliCantidad");
            }

            PeliCantidad.Add(idPelicula, cantidad);

            HttpContext.Session.SerializeObject("PeliCantidad",PeliCantidad);

            HttpContext.Session.SetString("notificacion",can.ToString());

            if (HttpContext.Session.GetString("notificacion") != null)
            {

                string canti = HttpContext.Session.GetString("notificacion");

                int not = int.Parse(canti) + 1;

                HttpContext.Session.SetString("notificacion", not.ToString());
            }
            else {

                HttpContext.Session.SetString("notificacion", "0");

            }

            return Json("funciona");
        }

        public IActionResult Carrito() {

            Dictionary<string, string> Pelis = HttpContext.Session.DeserializeObject<Dictionary<string, string>>("PeliCantidad");
            Dictionary<string, int> Precio = new Dictionary<string, int>();

            foreach (var e in Pelis) {

                int precio=this.repo.GetPreciosPelicula(e.Key);

                if (precio != 0)
                {
                    Precio.Add(e.Key,precio * int.Parse(e.Value));
                }
            }

            ViewBag.Precio = Precio;

            return View();
        }

        [AuthorizeAdmin]
        public IActionResult RealizarCompra(int id) {

            return View(id);
        }
    }
}
