using Microsoft.AspNetCore.Mvc;
using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreLinqXML.Controllers
{
    public class PeliculaController : Controller
    {
        private RepositoryPeliculas repo;

        public PeliculaController(RepositoryPeliculas repo){

            this.repo = repo;

        }

        public IActionResult Index()
        {
            List<Pelicula> peliculas = this.repo.GetPeliculas();

            return View(peliculas);
        }

        public IActionResult EscenasPeliculas(int id,int? posicion) {

            int numeroregistros = 0;

            if (posicion == null) {

                posicion = 0;
            }

            Escena escenas = this.repo.GetEscenasPelicula(id,posicion.Value,ref numeroregistros);
            ViewData["registros"] = "Escena " + posicion + " de " + numeroregistros;

            int siguiente = posicion.Value + 1;

            if (siguiente > numeroregistros) {

                siguiente = 0;
            }

            int anterior = posicion.Value - 1;

            if (anterior < 0) {

                anterior = numeroregistros-1;
            }

            ViewData["siguiente"] = siguiente;
            ViewData["anterior"] = anterior;

            return View(escenas);
        }

        public IActionResult Details(int id) {

            Pelicula pelicula = this.repo.GetPelicula(id);

            return View(pelicula);
        }

        public IActionResult _EscenasPeliculas(int id, int? posicion) {

            int numeroregistros = 0;

            if (posicion == null)
            {

                posicion = 0;
            }

            Escena escenas = this.repo.GetEscenasPelicula(id, posicion.Value, ref numeroregistros);
            ViewData["registros"] = "Escena " + posicion + " de " + numeroregistros;

            int siguiente = posicion.Value + 1;

            if (siguiente > numeroregistros)
            {

                siguiente = 0;
            }

            int anterior = posicion.Value - 1;

            if (anterior < 0)
            {

                anterior = numeroregistros - 1;
            }

            ViewData["siguiente"] = siguiente;
            ViewData["anterior"] = anterior;

            return PartialView("EscenasPeliculas",escenas);
        }


        [HttpPost]
        public IActionResult Posicionamiento(int id,int posicion) {

            int numeroregistros = 0;

            Escena escenas = this.repo.GetEscenasPelicula(id, posicion, ref numeroregistros);

            return Json(escenas);

        }
    }
}
