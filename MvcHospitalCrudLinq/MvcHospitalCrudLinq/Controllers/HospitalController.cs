using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcHospitalCrudLinq.Models;
using MvcHospitalCrudLinq.Data;

namespace MvcHospitalCrudLinq.Controllers
{
    public class HospitalController : Controller
    {
        HospitalContext context;

        public HospitalController() {

            this.context = new HospitalContext();
        }

        public IActionResult Index()
        {
            List<Hospital> Hospitales = this.context.GetHospitales();

            return View(Hospitales);
        }

        //Metodo GET de la vista
        public IActionResult InsertarHospital() {

            return View();
        }

        [HttpPost]
        public IActionResult InsertarHospital(string hospital_cod, string nombre,string direccion,string telefono,string num_cama) {

            this.context.InsertarHospital(hospital_cod,nombre,direccion,telefono,num_cama);

            return RedirectToAction("Index");
        }

        //Metodo GET de la vista
        public IActionResult ModificarHospital(string codigo) {

            Hospital hosp = this.context.BuscarHospital(codigo);

            return View(hosp);
        }

        [HttpPost]
        public IActionResult ModificarHospital(Hospital hosp)
        {

            this.context.ModificarHospital(hosp.Hospital_Cod,hosp.Nombre,hosp.Direccion,hosp.Telefono,hosp.Num_Cama);

            return RedirectToAction("Index");
        }

        public IActionResult EliminarHospital(string codigo) {

            this.context.EliminarHospital(codigo);

            return RedirectToAction("Index");
        }
    }
}
