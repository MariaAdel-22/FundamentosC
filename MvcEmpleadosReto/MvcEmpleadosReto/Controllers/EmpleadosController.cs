using MvcEmpleadosReto.Models;
using MvcEmpleadosReto.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEmpleadosReto.Controllers
{
    public class EmpleadosController : Controller
    {
        public RepositoryEmpleados repo;

        public EmpleadosController() {

            this.repo = new RepositoryEmpleados();
        }

        // GET: Empleados
        public ActionResult Index()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            return View(empleados);
        }
    }
}