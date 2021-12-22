using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcHospitalCrudLinq.Models
{
    public class Plantilla
    {
        public int Hospital_Cod { get; set; }
        public int Sala_Cod { get; set; }
        public int Empleado_No { get; set; }
        public string Apellido { get; set; }
        public string Funcion { get; set; }
        public Char T { get; set; }
        public int Salario { get; set; }
    }
}
