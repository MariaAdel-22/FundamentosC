using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNet.Models
{
    public class Plantilla
    {
        public int Hospital_cod { get; set; }
        public int Sala_cod { get; set; }
        public int Empleado_no { get; set; }
        public string Apellido { get; set;}
        public string Funcion { get; set; }
        public char T { get; set; }
        public int Salario { get; set; }
    }
}
