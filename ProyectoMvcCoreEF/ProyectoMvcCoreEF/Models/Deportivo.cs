using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreEF.Models
{
    /*Hacemos la herencia de una interfaz*/
    public class Deportivo:ICoche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Imagen { get; set; }
        public int Velocidad { get; set; }
        public int VelocidadMaxina { get; set; }

        public Deportivo()
        {

            this.Marca = "Deportivo";
            this.Modelo = "Nuevo";
            this.Imagen = "2.jpg";
            this.Velocidad = 0;
            this.VelocidadMaxina = 140;
        }

        public int Acelerar()
        {

            this.Velocidad += 20;

            if (this.Velocidad > this.VelocidadMaxina)
            {

                this.Velocidad = this.VelocidadMaxina;
            }
            return this.Velocidad;
        }

        public int Frenar()
        {

            this.Velocidad -= 20;

            if (this.Velocidad < 0)
            {

                this.Velocidad = 0;
            }

            return this.Velocidad;
        }
    }
}
