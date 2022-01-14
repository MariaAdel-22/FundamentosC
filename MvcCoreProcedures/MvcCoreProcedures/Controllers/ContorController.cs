using Microsoft.AspNetCore.Mvc;
using MvcCoreProcedures.Models;
using MvcCoreProcedures.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProcedures.Controllers
{
    public class ContorController : Controller
    {
        private RepositoryDoctores repo;

        public ContorController(RepositoryDoctores repo) {

            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<String> Especialidades = this.repo.GetEspecialidaes();
            ViewBag.Especialidad = Especialidades;

            List<Doctor> Doctores = this.repo.GetDoctores();
            return View(Doctores);
        }

        [HttpPost]
        public IActionResult Index(string especialidad,int incremento) {

            List<String> Especialidades = this.repo.GetEspecialidaes();
            ViewBag.Especialidad = Especialidades;

            this.repo.IncrementarSalario(especialidad,incremento);

            List<Doctor> doctores = this.repo.FindDoctores(especialidad);

            return View(doctores);
        }
    }
}
