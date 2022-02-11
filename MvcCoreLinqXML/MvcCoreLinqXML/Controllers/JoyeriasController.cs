using Microsoft.AspNetCore.Mvc;
using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreLinqXML.Controllers
{
    public class JoyeriasController : Controller
    {
        private RepositoryJoyeria repo;

        public JoyeriasController(RepositoryJoyeria repo) {

            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Joyeria> Joyerias = this.repo.GetJoyerias();

            return View(Joyerias);
        }
    }
}
