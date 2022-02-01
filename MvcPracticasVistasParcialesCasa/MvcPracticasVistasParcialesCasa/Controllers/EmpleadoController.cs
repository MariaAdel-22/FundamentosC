using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcPracticasVistasParcialesCasa.Extensions;
using MvcPracticasVistasParcialesCasa.Models;
using MvcPracticasVistasParcialesCasa.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticasVistasParcialesCasa.Controllers
{
    public class EmpleadoController : Controller
    {
        private RepositoryEmpleados repo;

        public EmpleadoController(RepositoryEmpleados repo) {

            this.repo = repo;
        }

        public IActionResult SessionEmpleadoCorrecto(int? idEmpleado)
        {

            if (idEmpleado != null)
            {

                List<int> listIdEmpleados;

                if (HttpContext.Session.GetString("IDEMPLEADOS") == null)
                {

                    //Si no existe nada en session creamos la colección(vacía)
                    listIdEmpleados = new List<int>();
                }
                else
                {

                    listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDEMPLEADOS");
                }

                //almacenamos el id dentro de la colección
                listIdEmpleados.Add(idEmpleado.Value);

                //ACTUALIZAMOS SESSION
                HttpContext.Session.SetObject("IDEMPLEADOS", listIdEmpleados);

                ViewData["MENSAJE"] = "Empleados almacenados" + listIdEmpleados.Count(); ;

            }
            return View(this.repo.GetEmpleado());
        }

        public IActionResult EmpleadosAlmacenadosCorrecto(int? eliminar)
        {

            List<int> listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDEMPLEADOS");


            if (listIdEmpleados == null)
            {

                ViewData["MENSAJE"] = "No existen empleados almacenados";

                return View();

            }
            else
            {

                if (eliminar != null)
                {

                    listIdEmpleados.Remove(eliminar.Value);

                    if (listIdEmpleados.Count() != 0)
                    {

                        HttpContext.Session.SetObject("IDEMPLEADOS", listIdEmpleados);
                    }
                    else
                    {
                        HttpContext.Session.Remove("IDEMPLEADOS");
                    }

                }

                //NECESITAMOS UN MÉTODO EN EL REPO QUE LE ENVIAREMOS UNA COLECCION DE ID Y NOS DEVOLVERÁ UNA COLECCIÓN DE EMPLEADOS
                List<Empleado> empleados = this.repo.EmpleadosPorColeccionId(listIdEmpleados);

                return View(empleados);
            }

        }

        [HttpPost]
        public IActionResult EmpleadosAlmacenadosCorrecto(List<string> cantidad)
        {
            TempData["MENSAJE"] = "Hola";
            TempData.Add("CANTIDAD1", cantidad);
            return RedirectToAction("ResumenCompra");
        }

        public IActionResult ResumenCompra()
        {

            string saludo = TempData["MENSAJE"].ToString();

            if (TempData.ContainsKey("CANTIDAD1"))
            {

                List<string> can = TempData["CANTIDAD1"] as List<string>;
                ViewBag.Cantidad = can;
            }

            List<int> listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDEMPLEADOS");

            List<Empleado> empleados = this.repo.EmpleadosPorColeccionId(listIdEmpleados);

            return View(empleados);

        }


        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(string apellido)
        {

            Empleado emp = this.repo.FindEmpleadoNombre(apellido);

            HttpContext.Session.SetObject("EMPLEADO", emp);

            return RedirectToAction("SessionEmpleadoCorrecto");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
