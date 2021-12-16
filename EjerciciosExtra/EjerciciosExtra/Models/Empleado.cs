using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosExtra.Models
{
    public class Empleado
    {
        public int Emp_no { get; set; }
        public string Apellido { get; set; }
        public string Oficio { get; set; }
        public int Dir { get; set; }
        public DateTime Fecha_alt { get; set; }
        public int Salario { get; set; }
        public int Comision { get; set; }
        public int Dept_no { get; set; }
    }
}
