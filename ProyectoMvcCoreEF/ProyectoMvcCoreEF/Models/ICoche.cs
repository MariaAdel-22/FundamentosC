using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreEF.Models
{
   public interface ICoche
    {
        /*Lo que haremos aquí será la declaración de cómo serán los objetos (qué propiedades van a tener) y sus métodos*/

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imagen { get; set; }
        public int Velocidad { get; set; }
        public int VelocidadMaxina { get; set; }

        int Acelerar();
        int Frenar();
    }
}
