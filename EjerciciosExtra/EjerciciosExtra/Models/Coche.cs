using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosExtra
{
    public class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public DateTime fechaInscripcion { get; set; }
        public byte[] Imagen { get; set; }
        public int Cod_Coche { get; set; }

        public Coche() { 
        
        }

        public Coche(string marca, string modelo, string color, DateTime fecha, byte[]imagen, int codigo) {

            this.Marca = marca;
            this.Modelo = modelo;
            this.Color = color;
            this.fechaInscripcion = fecha;
            this.Imagen = imagen;
            this.Cod_Coche = codigo;

        }
    }
}
