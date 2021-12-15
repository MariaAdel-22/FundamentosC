using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Matematicas.Models;

namespace Matematicas.Controllers
{
    public class MatematicasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Metodo GET de la vista SumarNumeros
        public IActionResult SumarNumeros() {

            return View();
        }

        //Metodo POST de la vista SumarNumeros

        [HttpPost]
        public IActionResult SumarNumeros(string num1, string num2)
        {
            int suma = int.Parse(num1) + int.Parse(num2);
            ViewBag.Suma = suma;

            return View();
        }

        //Metodo GET de la vista Collatz
        [HttpGet]
        public IActionResult Collatz(int num) {

            List<int> numeros = new List<int>();

            numeros.Add(num);

            int numero = num;

            while(numero != 1) {

                if (numero % 2 == 0) {

                    numero = numero / 2;

                    numeros.Add(numero);

                } else if (numero % 2 != 0 ) {

                    numero = (numero * 3) + 1;

                    numeros.Add(numero);
                }
                
            }

            return View(numeros);
        }

        //Metodo GET para la vista TablaMultiplicar

        public IActionResult TablaMultiplicar(Multiplicacion mul) {


            return View(mul);
        }

    }
}
