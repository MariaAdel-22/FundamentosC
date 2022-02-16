using Microsoft.AspNetCore.Mvc;
using MvcNetCoreClienteWCF.Services;
using ServicioCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Controllers
{
    public class CountrieController : Controller
    {
        private ServiceCountries service;

        public CountrieController(ServiceCountries service)
        {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            tCountryCodeAndName[] countries = await this.service.GetCountries();
            return View(countries);
        }
    }
}
