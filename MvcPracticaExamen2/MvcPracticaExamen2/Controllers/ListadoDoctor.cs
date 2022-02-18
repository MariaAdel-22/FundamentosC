using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen2.Controllers
{
    public class ListadoDoctor : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
