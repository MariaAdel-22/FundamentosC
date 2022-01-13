using MvcEmpleadosReto.Models;
using MvcEmpleadosReto.Repositories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcEmpleadosReto.Controllers
{
    public class EmpleadosController : Controller
    {
        public IRepository repo;

        public EmpleadosController(IRepository r) {

            this.repo = r;
        }

        // GET: Empleados
        public ActionResult Index()
        {
            List<Empleado> empleados = this.repo.GetEmpleados();
            return View(empleados);
        }

        public ActionResult Edit(int id) {

            Empleado emp = this.repo.findEmpleado(id);
            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(Empleado emp) {

            this.repo.ModificarEmpleado(emp.IdEmpleado,emp.Apellido,emp.Oficio,emp.Salario);

            return RedirectToAction("Index");
        }
    }
}