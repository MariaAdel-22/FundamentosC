using Microsoft.AspNetCore.Mvc;
using MvcSeguridadEmpleados.Filters;
using MvcSeguridadEmpleados.Models;
using MvcSeguridadEmpleados.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeguridadEmpleados.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleado repo;

        public EmpleadosController(RepositoryEmpleado repo) {

            this.repo = repo;
        }

        public IActionResult Empleados() {

            List<Empleado> empleados = this.repo.GetEmpleados();
            return View(empleados);

        }

        [AuthorizeEmpleado]
        public IActionResult PerfilEmpleado()
        {
            return View();
        }
    }
}
