using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class ColeccionCoches : List<Coche>
    {
        public  List<Coche> Coches {get;set;}

        public ColeccionCoches() {

            this.Coches = new List<Coche>();
        }
    }
}
