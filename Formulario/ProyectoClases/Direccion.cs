using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ProyectoClases
{
    public class Direccion
    {

        public Direccion() { //Creamos el constructor de la clase

            Debug.WriteLine("Constructor inicializado~");
        }

        //Multiples constructores y formas de crear un objeto

        public Direccion(String calle, String ciudad) {

            this.Calle = calle;
            this.Ciudad = ciudad;
            Debug.WriteLine("Constructor dirección con dos parámetros");
        }

        public string Calle { get; set; }
        public string Ciudad { get; set; }
        public int CodigoPostal { get; set; }

    }
}
