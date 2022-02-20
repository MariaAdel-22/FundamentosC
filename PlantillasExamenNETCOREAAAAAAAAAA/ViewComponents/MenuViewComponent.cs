using Microsoft.AspNetCore.Mvc;
using MvcPracticaExamen.Models;
using MvcPracticaExamen.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        private PeliculasRepository repo;


        public MenuViewComponent(PeliculasRepository repo) {

            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync() {

            List<Genero> Generos = this.repo.GetGeneros();
            List<Nacionalidad> Nacionalidades = this.repo.GetNacionalidades();

            ViewBag.Generos = Generos;
            ViewBag.Nacionalidades = Nacionalidades;

            return View();
        }
    }
}
