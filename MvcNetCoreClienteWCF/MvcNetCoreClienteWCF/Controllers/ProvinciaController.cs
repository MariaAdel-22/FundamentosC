using Microsoft.AspNetCore.Mvc;
using MvcNetCoreClienteWCF.Models;
using MvcNetCoreClienteWCF.Services;
using ReferenceCatrasto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Controllers
{
    public class ProvinciaController : Controller
    {
        private ServiceCatastro service;

        public ProvinciaController(ServiceCatastro service) {

            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            List<string> names = await this.service.GetProvincias();

            return View(names);
        }

        public async Task<IActionResult> Provincias() {

            List<Provincia> Provincias = await this.service.ProvinciasListado();

            return View(Provincias);
        }

        public async Task<IActionResult> Municipios(string idprovincia,string? municipio) {

            List<string> Municipios = await this.service.Municipios(idprovincia,municipio);

            return View(Municipios);
        }
    }
}
