using Microsoft.AspNetCore.Mvc;
using MvcNetCoreClienteWCF.Services;
using ServicioClientesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Controllers
{
    public class ClientesController : Controller
    {
        private ServiceClientesID service;

        public ClientesController(ServiceClientesID service) {
            this.service = service;
        }

        public async Task<IActionResult> Index()
        {
            Cliente[] clientes = await this.service.GetClientes();

            return View(clientes);
        }

        public async Task<IActionResult> Details(int id) {

            Cliente cliente = await this.service.FindCliente(id);

            return View(cliente);
        }
    }
}
