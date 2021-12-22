using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcHospitalCrudLinq.Data;
using MvcHospitalCrudLinq.Models;

namespace MvcHospitalCrudLinq.Controllers
{
    public class PlantillasController : Controller
    {
        PlantillaContext context;

        public PlantillasController() {

            this.context = new PlantillaContext();
        }

        public IActionResult PlantillaHospital(int idhospital)
        {
            ModelPlantillas model = this.context.GetPlantillasHospital(idhospital);

            return View(model);
        }
    }
}
