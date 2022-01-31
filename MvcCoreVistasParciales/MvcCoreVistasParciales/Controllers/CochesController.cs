using Microsoft.AspNetCore.Mvc;
using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Controllers
{
    public class CochesController : Controller
    {

        private List<Coche> Cars;

        public CochesController() {

            this.Cars = new List<Coche> {

                new Coche{ IdCoche = 1, Marca="Pontiac", Modelo="Firebr", VelocidadMaxima=123},
                new Coche{ IdCoche=2,Marca="Lamborgini",Modelo="Distint",VelocidadMaxima=140},
                new Coche{IdCoche=3,Marca="Ferrari",Modelo="Testarrosa",VelocidadMaxima=300 },
                new Coche{ IdCoche=4,Marca="Ford",Modelo="Mustang",VelocidadMaxima=290}
            };
        }


        public IActionResult Index()
        {
            return View(this.Cars);
        }

        //ESTA VISTA NO TENDRÁ NADA AL CARGAR, PERO EN SU INTERIOR CARGAREMOS VISTAS PARCIALES CON JQUERY
        //TENDREMOS UNA VISTA PARCIAL CON TODOS LOS COCHES
        public IActionResult PeticionAsincrona() {

            return View();
        }

        //NECESITAMOS UN METODO QUE SERÁ LLAMADO MEDIANTE LOAD()  DE JQUERY, LOS MÉTODOS IACTIONRESULT SIEMPRE DEVUELVEN PARTIALVIEW()
        public IActionResult _CochesPartial() {

            return PartialView("_CochesPartial", this.Cars);

        }

        public IActionResult _CochesDetailsPartial(int idcoche) {

            Coche car = this.Cars.SingleOrDefault(z => z.IdCoche == idcoche);

            return PartialView("_CochesDetailsPartial",car);
        }
    }
}
