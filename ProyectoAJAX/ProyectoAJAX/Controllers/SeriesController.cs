using Microsoft.AspNetCore.Mvc;
using ProyectoAJAX.Models;
using ProyectoAJAX.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAJAX.Controllers
{
    public class SeriesController : Controller
    {
        private RepositorySeries repo;

        public SeriesController(RepositorySeries repo) {

            this.repo = repo;
        }

        public IActionResult Details(int codigoSerie)
        {
            Serie serie = this.repo.FindSerie(codigoSerie);

            return View(serie);
        }
    }
}
