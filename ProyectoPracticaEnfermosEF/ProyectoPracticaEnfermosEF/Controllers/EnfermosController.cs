using Microsoft.AspNetCore.Mvc;
using ProyectoPracticaEnfermosEF.Models;
using ProyectoPracticaEnfermosEF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoPracticaEnfermosEF.Controllers
{
    public class EnfermosController : Controller
    {

        private RepositoryEnfermos repo;

        public EnfermosController(RepositoryEnfermos repo) {

            this.repo = repo;

        }

        public IActionResult Index()
        {
            List<Enfermo> Enfermos = this.repo.GetEnfermos();

            return View(Enfermos);
        }
    }
}
