using Microsoft.AspNetCore.Mvc;
using MvcNetCoreClienteWCF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Controllers
{
    public class MetodosVariosController : Controller
    {
        private ServiceMetodosVarios service;

        public MetodosVariosController(ServiceMetodosVarios service) {

            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string numero) {

            int[] numeros = await this.service.GetTablaMultiplicar(int.Parse(numero));

            ViewBag.numeros = numeros;
            return View();
        }
    }
}
