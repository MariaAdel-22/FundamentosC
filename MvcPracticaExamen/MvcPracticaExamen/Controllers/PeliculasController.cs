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

        public IActionResult _DetallePeliculaG(string id) {

            Pelicula pel = this.repo.GetPeliculaGenero(int.Parse(id));

            return PartialView("_DetallePeliculaG", pel);
        }
    }
}
