using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreLinqSQL.Data;
using NetCoreLinqSQL.Models;

namespace NetCoreLinqSQL.Controllers
{
    public class EmpleadosController : Controller
    {
        EmpleadosContext context;

        public EmpleadosController() {

            this.context = new EmpleadosContext();
        }

        public IActionResult TodosEmpleados() {

            List<Empleado> empleados = this.context.GetEmpleados();

            return View(empleados);
        
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
