using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosExtra.Models
{
    public class Enfermo
    {
        public string Inscripcion { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_nac { get; set; }
        public Char S { get; set; }
        public string Seg_social { get; set; }
    }
}
