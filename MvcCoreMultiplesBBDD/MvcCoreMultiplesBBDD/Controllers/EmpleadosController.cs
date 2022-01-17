using Microsoft.AspNetCore.Mvc;
using MvcCoreMultiplesBBDD.Models;
using MvcCoreMultiplesBBDD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo) {

            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();

            return View(empleados);
        }

        public IActionResult Details(int id) {

            Empleado emp = this.repo.FindEmpleado(id);
            return View(emp);
        }

        public IActionResult Delete(int id) {

            this.repo.DeleteEmpleado(id);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateSalario(int id) {

            Empleado emp = this.repo.FindEmpleado(id);

            return View(emp);
        }

        [HttpPost]
        public IActionResult UpdateSalario(int idempleado,int incremento) {

            this.repo.UpdateSalarioEmpleado(idempleado,incremento);

            Empleado em = this.repo.FindEmpleado(idempleado);
           
            return View(em);
        }
    }
}
