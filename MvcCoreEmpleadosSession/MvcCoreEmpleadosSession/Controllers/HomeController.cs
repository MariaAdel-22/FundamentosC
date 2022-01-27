using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCoreEmpleadosSession.Helpers;
using MvcCoreEmpleadosSession.Models;
using MvcCoreEmpleadosSession.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEmpleadosSession.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private RepositoryEmpleado repoEmpleado;
        private HelperEmpleados helper;

        public HomeController(ILogger<HomeController> logger,RepositoryEmpleado empleado,HelperEmpleados helper)
        {
            _logger = logger;
            this.repoEmpleado = empleado;
            this.helper = helper;
        }

        public IActionResult Index()
        {
            List<Empleado> Empleados = this.repoEmpleado.GetEmpleado();
            
            return View(Empleados);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
