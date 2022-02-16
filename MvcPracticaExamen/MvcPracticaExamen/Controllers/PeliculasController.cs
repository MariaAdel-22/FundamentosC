using Microsoft.AspNetCore.Mvc;
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
        public JsonResult InsertarCarrito(string idPelicula,string cantidad) {

            List<string> Peliculas = new List<string>();
            Peliculas.Add(idPelicula);

            List<string> Cantidad = new List<string>();
            Cantidad.Add(cantidad);

            TempData["idPelicula"] = Peliculas;
            TempData["cantidad"] = cantidad;

            idPelicula += idPelicula + ",";
           
            HttpContext.Response.Cookies.Append("IdPelicula",idPelicula);

            cantidad += cantidad + ",";

            HttpContext.Response.Cookies.Append("Cantidad",cantidad);

            //return Json(new { result = "Redirect", url = Url.Action("Carrito", "Peliculas", new { idPelicula = idPelicula, cantidad = cantidad }) }) ;
            return Json("funciona");
        }

        public IActionResult Carrito() {

            List<string>Peliculas= TempData["idPelicula"] as List<string>;

            ViewBag.Pelicula = Peliculas;

            ViewBag.Cantidad= TempData["cantidad"] as List<string>;

            List<string> Precio = new List<string>();

            foreach (string idP in Peliculas) {

                string precio = this.repo.GetPreciosPelicula(idP);

                Precio.Add(precio);
            }

            ViewBag.Precio = Precio;

            return View();
        }
    }
}
