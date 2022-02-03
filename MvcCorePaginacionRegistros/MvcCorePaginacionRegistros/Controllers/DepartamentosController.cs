using Microsoft.AspNetCore.Mvc;
using MvcCorePaginacionRegistros.Models;
using MvcCorePaginacionRegistros.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCorePaginacionRegistros.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryHospital repo;

        public DepartamentosController(RepositoryHospital repo) {

            this.repo = repo;
        }

        public IActionResult PaginarGrupoVistaDepartamento(int? posicion) {

            if (posicion == null) {

                posicion = 1;
            }

            int numeroregistros = this.repo.GetNumeroRegistros();

            //<a href="PaginarGrupo?posicion=1">Pagina 1</a>
            //<a href="PaginarGrupo?posicion=3">Pagina 2</a>

            //NECESITAMOS UN CONTADOR PARA DIBUJAR EL NUMERO DE PAGINA
            int numeroPagina = 1;

            //También necesitamos un bucle para dibujar el <a> varias veces y comiente en 1, y vaya subiendo de 2 en 2
            string html = "<div>";

            for (int i=1;i<=numeroregistros;i+=2) {

                html += "<a href='PaginarGrupoVistaDepartamento?posicion='"+i+">Pagina "+numeroPagina+"</a><br/>";

                numeroPagina += 1;
            }

            html += "</div>";

            ViewData["LINKS"] = html;

            List<VistaDepartamentoRegistro> lista = this.repo.GetGrupoVistaDepartamento(posicion.Value);

            return View(lista);
        }

        public IActionResult PaginarRegistroVistaDepartamento(int? posicion)
        {
            if (posicion == null) {

                posicion = 1;
            }

            int numRegistros = this.repo.GetNumeroRegistros();
            int siguiente = posicion.Value + 1;

            //Si me paso de posicion debo comprobar si nos pasamos del número de registros

            if (siguiente > numRegistros) {

                //Podemos volver a la posicion 1 por ejemplo

                //o dejarlo en la última posición nada más deshabilitando el botón de siguiente

                siguiente = numRegistros;
            }

            int anterior = posicion.Value - 1;

            if (anterior < 1) {

                anterior = 1;
            }

            ViewData["ULTIMO"] = numRegistros;
            ViewData["SIGUIENTE"] = siguiente;
            ViewData["ANTERIOR"] = anterior;

            VistaDepartamentoRegistro vista = this.repo.GetVistaDepartamento(posicion.Value);
            return View(vista);
        }
    }
}
