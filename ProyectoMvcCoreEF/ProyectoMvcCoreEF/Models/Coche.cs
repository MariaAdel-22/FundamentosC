using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreEF.Models
{
    public class Coche:ICoche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imagen { get; set; }
        public int Velocidad { get; set; }
        public int VelocidadMaxina { get; set; }

        public Coche() {

            this.Marca = "BatMovil";
            this.Modelo = "Antiguo";
            this.Imagen = "1.jpg";
            this.Velocidad = 0;
            this.VelocidadMaxina = 100;
        }

        public int Acelerar() {

            this.Velocidad += 20;

            if (this.Velocidad > this.VelocidadMaxina) {

                this.Velocidad = this.VelocidadMaxina;
            }
            return this.Velocidad;
        }

        public int Frenar() {

            this.Velocidad -= 20;

            if (this.Velocidad < 0) {

                this.Velocidad = 0;
            }

            return this.Velocidad;
        }
    }
}
