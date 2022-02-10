﻿using Microsoft.AspNetCore.Mvc;
using MvcSeguridadDoctores.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcSeguridadDoctores.Filters;
using MvcSeguridadDoctores.Models;

namespace MvcSeguridadDoctores.Controllers
{
    public class EnfermosController : Controller
    {
        private RepositoryEnfermos repo;

        public EnfermosController(RepositoryEnfermos repo) {

            this.repo = repo;
        }

        public IActionResult Index()
        {
            List<Enfermo> enfermos = this.repo.GetEnfermos();

            return View(enfermos);
        }

        [AuthorizeEnfermos]
        public IActionResult EliminarEnfermo(int idEnfermo) {

            TempData["Enfermo"] = idEnfermo;
            Enfermo enf = this.repo.FindEnfermo(idEnfermo);

            ViewBag.Enfermo = enf;
            return View();
        }

        [HttpPost]
        public IActionResult EliminarEnfermo() {

            this.repo.EliminarEnfermo(int.Parse(TempData["Enfermo"].ToString()));

            return View("Index");
        }

    }
}
