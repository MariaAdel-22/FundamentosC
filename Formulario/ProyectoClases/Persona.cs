using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Persona //Hay que poner public porque por defecto la clase viene private
    {

        private string _Nombre;

        /*Las propiedades siempre se declaran con get y set, lo demás es un campo. Las propiedades trabajan con campos privados que manejan la propiedad, la propiedad es pública pero yo
         con el campo privado decido que hacer (es mio)*/

        private int _Edad;

        public int Edad
        {
            get {
                return this._Edad;
            }

            set {

                if (value < 0) //Para controlar de que no nos recoga un valor negativo en la edad
                {

                    this._Edad = 0;

                    //Para lanzar una excepcion

                    throw new Exception("El valor de la edad no puede ser negativo");
                }
                else
                {

                    this._Edad = value; //value es cualquier valor que le pasamos al método set al llamarlo
                }
            }
        }

        public String Nombre { get; set; }

    }
}
