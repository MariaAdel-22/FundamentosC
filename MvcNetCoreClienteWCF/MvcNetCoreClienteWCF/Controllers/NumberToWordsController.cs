using Microsoft.AspNetCore.Mvc;
using MvcNetCoreClienteWCF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Controllers
{
    public class NumberToWordsController : Controller
    {
        public ServiceNumberConversion service;

        public NumberToWordsController(ServiceNumberConversion service) {

            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(int numero) {

            string respuesta = await this.service.GetNumberToWords(numero);
            ViewData["RESPUESTA"] = respuesta;

            return View();
        }
    }
}
