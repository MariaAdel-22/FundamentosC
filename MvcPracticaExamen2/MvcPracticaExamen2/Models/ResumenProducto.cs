using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen2.Models
{
    public class ResumenProducto
    {

        public int PrecioTotal { get; set; }
        public int CantidadTotal { get; set; }
        public List<Doctor> DoctoresComprados { get; set; }
    }
}
