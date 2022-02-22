using Microsoft.AspNetCore.Mvc;
using MvcNetCoreClienteWCF.Services;
using ServiceCochesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Controllers
{
    public class CochesController : Controller
    {
        private ServiceCoches service;

        public CochesController(ServiceCoches service) {

            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            Coche[] coches = await this.service.GetCoches();

            return View(coches);
        }

        public async Task<IActionResult> Details(int id) {

            Coche car = await this.service.FindCoche(id);

            return View(car);
        }
    }
}
