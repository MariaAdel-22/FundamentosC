using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcPracticaExamen2.Extensions;
using MvcPracticaExamen2.Filters;
using MvcPracticaExamen2.Models;
using MvcPracticaExamen2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MvcPracticaExamen2.Controllers
{
    public class DoctorController : Controller
    {

        private RepositoryDoctor repo;

        public DoctorController(RepositoryDoctor repo) {

            this.repo = repo;
        }

        public IActionResult ListadoDoctores()
        {
            List<Doctor> Doctores = this.repo.GetDoctores();
            return View(Doctores);
        }

        [AuthorizeDoctores(Policy = "AccesoEspecial")]
        public IActionResult AdministracionDoctores() {

            List<Doctor> Doctores = this.repo.GetDoctores();
            return View(Doctores);
        }

        [HttpPost]
        public JsonResult InsertarCarrito(int id) {
        
            Doctor doc = this.repo.FindDoctor(id);

            if (doc != null)
            { 
               
                List<Doctor> DoctProduct;

                if (HttpContext.Session.GetString("Productos") != null)
                {

                    DoctProduct = HttpContext.Session.GetObject<List<Doctor>>("Productos");

                    if (DoctProduct.Contains(doc) == false)
                    {
                        DoctProduct.Add(doc);
                        HttpContext.Session.SetObject("Productos", DoctProduct);

                    }
                }
                else
                {
                    DoctProduct = new List<Doctor>();

                    DoctProduct.Add(doc);
                    HttpContext.Session.SetObject("Productos", DoctProduct);
                }
            }


            if (HttpContext.Session.GetString("Notificacion") == null)
            {

                HttpContext.Session.SetString("Notificacion", "1");

            }
            else {

                string sum = HttpContext.Session.GetString("Notificacion");

                HttpContext.Session.SetString("Notificacion", (int.Parse(sum)+1).ToString());
            }

            return Json("Funciona");
        }

        public IActionResult Carrito() {

            return View();
        }

        [AuthorizeDoctores]
        [HttpPost]
        public IActionResult Carrito(string[] cantidad,string[] precio) {

            ResumenProducto factura = new ResumenProducto();

            int precioTotal= 0;
            int cantidadTotal = 0;

            for (int i=0;i<cantidad.Length;i++) {

                precioTotal += int.Parse(cantidad[i]) * int.Parse(precio[i]);
                cantidadTotal += int.Parse(cantidad[i]);
            }

            factura.PrecioTotal = precioTotal;
            factura.CantidadTotal = cantidadTotal;

            if (HttpContext.Session.Get("Productos") != null) { 
                factura.DoctoresComprados = HttpContext.Session.GetObject<List<Doctor>>("Productos");
            }
            

            return RedirectToAction("Factura",factura);
        }

        public IActionResult Factura(ResumenProducto factura) {


            return View(factura);
        }

        public IActionResult Perfil() {

            int IdDoctor = int.Parse(HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value);

            Doctor doc = this.repo.FindDoctor(IdDoctor);

            return View(doc);
        }

        public IActionResult InsertarDoctor() {

            return RedirectToAction("Administracion", "Doctores");
        }

        public IActionResult Modificar(int id) {

            Doctor doc = this.repo.FindDoctor(id);

            return View(doc);
        }

        [HttpPost]
        public IActionResult Modificar(string IdHospital,string IdDoctor,string Apellido,string Especialidad,string Salario) {

            Doctor doc = this.repo.FindDoctor(int.Parse(IdHospital));

            if (doc != null) {

                doc.IdHospital = int.Parse(IdHospital);
                doc.Apellido = Apellido;
                doc.Especialidad = Especialidad;
                doc.Salario = int.Parse(Salario);
            }

            return View();
        }

        public IActionResult Eliminar(int id) {

            Doctor doc = this.repo.FindDoctor(id);


            List<Doctor> doctores = HttpContext.Session.GetObject<List<Doctor>>("Productos");

            if (doctores.Contains(doc)) {

                doctores.Remove(doc);

                HttpContext.Session.SetObject("Productos", doctores);
            }

           this.repo.EliminarDoctor(id);

            return View("AdministracionDoctores");
        }
    }
}
