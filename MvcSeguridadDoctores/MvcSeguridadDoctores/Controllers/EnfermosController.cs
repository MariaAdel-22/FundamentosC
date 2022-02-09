using Microsoft.AspNetCore.Mvc;
using MvcSeguridadDoctores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcSeguridadDoctores.Filters;

namespace MvcSeguridadDoctores.Controllers
{
    public class EnfermosController : Controller
    {
        private RepositoryEnfermos repo;

        public EnfermosController(RepositoryEnfermos repo) {

            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AuthorizeEnfermos]
        public IActionResult EliminarEnfermo() {

            return View();
        }
    }
}
