using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Mes
    {

        #region PROPIEDADES DE LA CLASE

        public String _Nombre{get;set;}
        public int _temperaturaMaxima { get; set; }

        public int _temperaturaMinima { get; set; }

        public Mes() { }

        public Mes(string nombre,int temperaturaMaxina,int temperaturaMinima) {

            this._Nombre = nombre;
            this._temperaturaMaxima = temperaturaMaxina;
            this._temperaturaMinima = temperaturaMinima;

        }
        #endregion

        #region METODOS DE LA CLASE

        public int CalcularTemperaturaMedia(int maxima,int minima) {

            return maxima / minima;

        }

        #endregion
    }
}
