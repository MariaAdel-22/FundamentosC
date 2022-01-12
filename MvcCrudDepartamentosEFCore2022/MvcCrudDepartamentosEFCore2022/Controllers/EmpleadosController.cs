using Microsoft.AspNetCore.Mvc;
using MvcCrudDepartamentosEFCore2022.Models;
using MvcCrudDepartamentosEFCore2022.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleados repo;

        public EmpleadosController(RepositoryEmpleados repo) {

            this.repo = repo;
        }

        public IActionResult EmpleadosSalario() {

            //La primera vez devolvemos todos los empleados
            List<Empleado> empleados = this.repo.GetEmpleados();

            //Ncesitamos los oficios para dibujarlos en el desplegable
            List<string> oficios = this.repo.GetOficios();

            ViewData["OFICIOS"] = oficios;
            return View(empleados);
        }

        [HttpPost]
        public IActionResult EmpleadosSalario(string oficio,int incremento) {

            this.repo.IncrementarSalarioOficio(oficio, incremento);

            //recuperamos los empleados por oficio
            List<Empleado> empleados = this.repo.GetEmpleadosOficio(oficio);

            //Necesitamos los oficios para seguir dibujando el desplegable a pesar el ser el post
            List<string> oficios = this.repo.GetOficios();
            ViewData["OFICIOS"] = oficios;

            return View(empleados);
        }

        public IActionResult EmpleadosDepartamento(int id) {

            List<Empleado> empleados = this.repo.GetEmpleadosDepartamentos(id);
            return View(empleados);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
