using Microsoft.AspNetCore.Mvc;
using MvcCoreProcedures.Models;
using MvcCoreProcedures.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProcedures.Controllers
{
    public class TrabajadoresController : Controller
    {
        private RepositoryTrabajadores repo;

        public TrabajadoresController(RepositoryTrabajadores repo) {

            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<string> Oficios = this.repo.GetOficios();
            ViewData["OFICIOS"] = Oficios;

            return View();
        }

        [HttpPost]
        public IActionResult Index(string oficio) {

            List<string> Oficios = this.repo.GetOficios();
            ViewData["OFICIOS"] = Oficios;

            ResumenTrabajadores datos = this.repo.GetResumenTrabajadores(oficio);
            return View(datos);
        }
    }
}
