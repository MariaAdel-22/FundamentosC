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

        //Lo que hacemos es pasarle por GET a éste método el id del departamento desde la vista Index
        public IActionResult Details(int id) {

            Departamento dep = this.context.FindDepartamento(id);
            return View(dep);
        }

        //Metodo GET de la vista Create
        public IActionResult Create() {

            return View();
        }

        [HttpPost]
        public IActionResult Create(int id, string nombre, string localidad)
        {
            int results= this.context.InsertarDepartamento(id, nombre, localidad);
            ViewBag.Mensaje = "Se ha insertado " + results + "departamento";

            return RedirectToAction("Index");
        }

        //Metodo GET de la vista Update, en este método recibimos el ID del departamento que queremos editar, y a la vista le doy el departamento que se quiere editar para mostrar sus valores en el form
        public IActionResult Update(int id) {

            Departamento dep = this.context.FindDepartamento(id);

            return View(dep);
        }

        [HttpPost]
        public IActionResult Update(Departamento departamento) {

            int result=this.context.UpdateDepartamento(departamento.IdDepartamento,departamento.Nombre,departamento.Localidad);
            ViewData["MENSAJE"] = "Se ha modificado " + result + " departamento";

            return View(departamento);
        }

        public IActionResult Delete(int id) {

            this.context.DeleteDepartamento(id);

            return RedirectToAction("Index");
        }

        //Metodo GET de la vista. Como los departamentos es una herramienta para hacerlo más visual, le pasamos la colección por ViewBag a la vista.

        public IActionResult EmpleadosDepartamento() {

            List<Departamento> departamentos = this.context.GetDepartamentos();
            ViewBag.Departamentos = departamentos;

            return View();
        }

        //Método POST de la vista. Lo que queremos mostrar es los empleados en la vista y por ello le enviamos los empleados por Model.

        [HttpPost]
        public IActionResult EmpleadosDepartamento(int idD) {

            List<Empleado> empleados = this.context.GetEmpleadosDepartamento(idD);
            List<Departamento> departamentos = this.context.GetDepartamentos();//Quiero que siga apareciendo la lista desplegable con los departamentos aún recibiendo los datos por eso lo envío de nuevo

            ViewBag.Departamentos = departamentos;

            return View(empleados);
        }
    }
}
