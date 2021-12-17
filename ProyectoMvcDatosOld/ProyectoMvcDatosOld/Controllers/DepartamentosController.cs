using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMvcDatosOld.Data;
using ProyectoMvcDatosOld.Models;

namespace ProyectoMvcDatosOld.Controllers
{
    public class DepartamentosController : Controller
    {
        DepartamentosContext context;

        public DepartamentosController() {

            this.context = new DepartamentosContext();
        }

        //Lo que hacemos es recoger toda la colección de departamentos traida de la bbdd y se lo pasamos a la vista Index para que la recoga con @Model
        public IActionResult Index()
        {
            List<Departamento> lista = this.context.GetDepartamentos();

            return View(lista);
        }
    }
}
