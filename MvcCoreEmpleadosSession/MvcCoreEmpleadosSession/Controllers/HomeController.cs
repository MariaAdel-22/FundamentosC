using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCoreEmpleadosSession.Extensions;
using MvcCoreEmpleadosSession.Helpers;
using MvcCoreEmpleadosSession.Models;
using MvcCoreEmpleadosSession.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEmpleadosSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private RepositoryEmpleado repoEmpleado;
        private HelperEmpleados helper;

        public HomeController(ILogger<HomeController> logger,RepositoryEmpleado empleado,HelperEmpleados helper)
        {
            _logger = logger;
            this.repoEmpleado = empleado;
            this.helper = helper;
        }

        public IActionResult SessionSalarios(int? salario)
        {
            if (salario != null) {

                int sumaSalarial = 0;

                if (HttpContext.Session.GetString("SUMASALARIAL") != null) {

                    //significa que existe la variable de sesion y recuperamos su valor

                    sumaSalarial = int.Parse(HttpContext.Session.GetString("SUMASALARIAL"));
                }

                //SUMAMOS EL SALARIO RECIBIDO CON LO QUE TENGAMOS YA ALMACENADO

                sumaSalarial += salario.Value;

                //ALMACENAMOS EL NUEVO VALOR EN SESSION MODIFICANDOLO

                HttpContext.Session.SetString("SUMASALARIAL", sumaSalarial.ToString());

                ViewData["MENSAJE"] = "Salario almacenado: " + salario.Value;
            }

            List<Empleado> Empleados = this.repoEmpleado.GetEmpleado();
            
            return View(Empleados);
        }

        public IActionResult SumaSalarios()
        {
            return View();
        }


        //VERSION 2.0

        public IActionResult SessionEmpleados(int? idEmpleado) {

            if (idEmpleado != null)
            {

                //Buscamos al empleado
                Empleado empleado = this.repoEmpleado.FindEmpleado(idEmpleado.Value);

                //Necesitamos almacenar un conjunto de empleados
                List<Empleado> empleadosSession;

                //Comprobamos si existen empleaods en session

                if (HttpContext.Session.GetObject<List<Empleado>>("EMPLEADOS") != null)
                {

                    empleadosSession = HttpContext.Session.GetObject<List<Empleado>>("EMPLEADOS");

                }
                else {

                    empleadosSession = new List<Empleado>();
                }

                //ALMACENAMOS EL EMPLEADO EN LA COLECCION

                empleadosSession.Add(empleado);

                //ACTUALIZAMOS SESSION

                HttpContext.Session.SetObject("EMPLEADOS", empleadosSession);

                ViewData["MENSAJE"] = "Empleado " + empleado.CodigoEmpleado + " almacenado en Session";
            }
   
            return View(this.repoEmpleado.GetEmpleado());
        }

        public IActionResult SessionEmpleado() {

            return View();
        }

        //VERSION 3.0

        public IActionResult SessionEmpleadoCorrecto(int? idEmpleado) {

            if (idEmpleado != null) {

                List<int> listIdEmpleados;

                if (HttpContext.Session.GetString("IDEMPLEADOS") == null)
                {

                    //Si no existe nada en session creamos la colección(vacía)
                    listIdEmpleados = new List<int>();
                }
                else {

                    listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDEMPLEADOS");
                }

                //almacenamos el id dentro de la colección
                listIdEmpleados.Add(idEmpleado.Value);

                //ACTUALIZAMOS SESSION
                HttpContext.Session.SetObject("IDEMPLEADOS", listIdEmpleados);

                ViewData["MENSAJE"] = "Empleados almacenados" + listIdEmpleados.Count(); ;

            }
            return View(this.repoEmpleado.GetEmpleado());
        }

        public IActionResult EmpleadosAlmacenadosCorrecto(int? eliminar) {

            List<int> listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDEMPLEADOS");


            if (listIdEmpleados == null)
            {

                ViewData["MENSAJE"] = "No existen empleados almacenados";

                return View();

            }
            else {

                if (eliminar != null) {

                    listIdEmpleados.Remove(eliminar.Value);

                    if (listIdEmpleados.Count() != 0)
                    {

                        HttpContext.Session.SetObject("IDEMPLEADOS", listIdEmpleados);
                    }
                    else {
                        HttpContext.Session.Remove("IDEMPLEADOS");
                    }
                   
                }

                //NECESITAMOS UN MÉTODO EN EL REPO QUE LE ENVIAREMOS UNA COLECCION DE ID Y NOS DEVOLVERÁ UNA COLECCIÓN DE EMPLEADOS
                List<Empleado> empleados = this.repoEmpleado.EmpleadosPorColeccionId(listIdEmpleados);

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

        public IActionResult ResumenCompra() {

            string saludo = TempData["MENSAJE"].ToString();

             if (TempData.ContainsKey("CANTIDAD1")) {

                List<string> can = TempData["CANTIDAD1"] as List<string>;
                 ViewBag.Cantidad = can;
             }

            List<int> listIdEmpleados = HttpContext.Session.GetObject<List<int>>("IDEMPLEADOS");

            List<Empleado> empleados = this.repoEmpleado.EmpleadosPorColeccionId(listIdEmpleados);

            return View(empleados);
        
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
