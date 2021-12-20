using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreLinqSQL.Models
{
    public class Enfermo
    {
        public String Inscripcion { get; set; }
        public String Apellido { get; set; }
        public String Direccion { get; set; }
        public DateTime Fecha_nac { get; set; }
        public Char S { get; set; }
        public String NSS{get;set;}
    }
}
