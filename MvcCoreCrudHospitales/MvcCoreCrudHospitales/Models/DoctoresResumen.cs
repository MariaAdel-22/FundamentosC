using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCrudHospitales.Models
{
    public class DoctoresResumen
    {
        public int MaximoSalario { get; set; }
        public double MediaSalario { get; set; }
        public int SumaSalarial { get; set; }
        public List<Doctor> docs { get; set; }
    }
}
