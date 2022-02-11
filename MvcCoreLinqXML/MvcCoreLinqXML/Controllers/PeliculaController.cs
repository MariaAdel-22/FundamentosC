﻿using Microsoft.AspNetCore.Mvc;
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

        public IActionResult EscenasPeliculas(int id) {

            List<Escena> escenas = this.repo.GetEscenasPelicula(id);

            return View(escenas);
        }
    }
}
