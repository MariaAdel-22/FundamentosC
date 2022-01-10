using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMvcCoreEF.Data;
using ProyectoMvcCoreEF.Models;

namespace ProyectoMvcCoreEF.Controllers
{
    public class DepartamentosController : Controller
    {
        private DepartamentosContextSQLServer context;

        public DepartamentosController(DepartamentosContextSQLServer context) {

            this.context = context;
        
        }

        public IActionResult Index()
        {
            List<Departamento> departamentos = this.context.GetDepartamentos();

            return View(departamentos);
        }

        public IActionResult Create() {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Departamento departamento) {

            this.context.InsertarDepartamento(departamento.IdDepartamento, departamento.Nombre, departamento.Localidad);

            return RedirectToAction("Index");
        }
    }
}
