using Microsoft.AspNetCore.Mvc;
using MvcCorePaginacionRegistros.Models;
using MvcCorePaginacionRegistros.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCorePaginacionRegistros.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryHospital repo;

        public EmpleadosController(RepositoryHospital repo) {

            this.repo = repo;
        }

        public IActionResult EmpleadosGrupalPaginacion(int? posicion,string oficio)
        {
            if (posicion == null)
            {

                posicion = 1;
                return View();
            }
            else { 

               int numeroRegistros = 0;

               List<Empleado> empleados = this.repo.GetGrupoEmpleados(posicion.Value, oficio, ref numeroRegistros);
               
                ViewData["REGISTRO"] = numeroRegistros;
                ViewData["OFICIO"] = oficio;

                View(empleados);
            }
            
            return View();
        }

        [HttpPost]
        public IActionResult EmpleadosGrupalPaginacion(string oficio) {

            int numeroRegistros = 0;

            List<Empleado> empleados = this.repo.GetGrupoEmpleados(1,oficio, ref numeroRegistros);

            ViewData["REGISTRO"] = numeroRegistros;
            ViewData["OFICIO"] = oficio;

            return View(empleados);
        }
    }
}
