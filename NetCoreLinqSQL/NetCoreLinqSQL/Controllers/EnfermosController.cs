using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreLinqSQL.Data;
using NetCoreLinqSQL.Models;

namespace NetCoreLinqSQL.Controllers
{
    public class EnfermosController : Controller
    {
        EnfermosContext context;

        public EnfermosController() {

            this.context = new EnfermosContext();
        }

        public IActionResult Index()
        {
            return View();
        }

        //Metodo GET de la vista
        public IActionResult DeleteEnfermo() {

            List<Enfermo> Enfermos = this.context.GetEnfermos();

            return View(Enfermos);
        }

        [HttpPost]
        public IActionResult DeleteEnfermo(int inscripcion) {

            this.context.EliminarEnfermo(inscripcion);

            //Al poner este código lo que pasa es que, al pulsar el botón de eliminar, la primera vez no va pero a la segunda si
           List<Enfermo> Enfermos = this.context.GetEnfermos();

            return View(Enfermos);
        
        }
    }
}
