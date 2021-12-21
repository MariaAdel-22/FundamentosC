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

        public IActionResult Details(int idempleado) {

            Empleado emp = new Empleado();
            emp = this.context.FindEmpleado(idempleado);

            return View(emp);
        }

        //METODO GET DE LA VISTA
        public IActionResult BuscarEmpleadosOficioSalario()
        {

            return View();
        }

        [HttpPost]
        public IActionResult BuscarEmpleadosOficioSalario(int salario, string oficio) {

            List<Empleado> empleados = this.context.GetEmpleadosOficioSalario(oficio,salario);

            return View(empleados);
        }

        //Metodo GET de la vista

        public IActionResult IncrementarSalarios() {

            List<string> Oficios = this.context.GetOficios();

            ViewBag.Oficios = Oficios;

            return View();
        }

        [HttpPost]
        public IActionResult IncrementarSalarios(string oficio,int incremento) {

            List<string> Oficios = this.context.GetOficios();

            ViewBag.Oficios = Oficios;

            int res = this.context.IncrementarSalarioEmpleadosOficio(oficio,incremento);
            List<Empleado> Empleados = this.context.EmpleadosOficio(oficio);

            return View(Empleados);
        }
    }
}
