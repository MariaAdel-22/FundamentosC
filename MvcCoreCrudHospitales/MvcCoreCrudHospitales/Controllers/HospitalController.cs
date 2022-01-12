using Microsoft.AspNetCore.Mvc;
using MvcCoreCrudHospitales.Models;
using MvcCoreCrudHospitales.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCrudHospitales.Controllers
{
    public class HospitalController : Controller
    {
        private RepositoryHospital repo;

        public HospitalController(RepositoryHospital repo) {

            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Hospital> hospitales = this.repo.GetHospitales();

            return View(hospitales);
        }

        public IActionResult Details(int id) {

            Hospital hosp = this.repo.FindHospital(id);
            return View(hosp);
        }

        public IActionResult Create() {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Hospital hosp) {

            this.repo.InsertarHospital(hosp.Nombre,hosp.Direccion,hosp.Telefono,hosp.Camas);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id) {

            this.repo.EliminarHospital(id);

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id) {

            Hospital hosp = this.repo.FindHospital(id);
            return View(hosp);
        }

        [HttpPost]
        public IActionResult Edit(Hospital hosp) {

            this.repo.ModificarHospital(hosp.IdHospital,hosp.Nombre,hosp.Direccion,hosp.Telefono,hosp.Camas);
            return RedirectToAction("Index");
        }
    }
}
