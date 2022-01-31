using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcCoreVistasParciales.Models;
using MvcCoreVistasParciales.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RepositoryCoches repo;
        public HomeController(ILogger<HomeController> logger, RepositoryCoches repo)
        {
            _logger = logger;
            this.repo = repo;
        }

        public IActionResult Login() {

            return View();
        }

        [HttpPost]
        public IActionResult Login(string usuario) {

            HttpContext.Session.SetString("USUARIO", usuario);
            return RedirectToAction("Index");
        }

        public IActionResult CloseSession() {

            HttpContext.Session.Remove("USUARIO");
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
            return View();
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
