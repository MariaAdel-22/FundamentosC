using Microsoft.AspNetCore.Mvc;
using ProyectoAJAX.Models;
using ProyectoAJAX.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAJAX.ViewComponents
{
    public class MenuDesplegableSeriesViewComponent:ViewComponent
    {
        private RepositorySeries repo;

        public MenuDesplegableSeriesViewComponent(RepositorySeries repo) {

            this.repo = repo;
        }

        public async Task<IViewComponentResult> InvokeAsync() {

            List<Serie> Series = this.repo.GetSeries();

            return View(Series);
        }
    }
}
