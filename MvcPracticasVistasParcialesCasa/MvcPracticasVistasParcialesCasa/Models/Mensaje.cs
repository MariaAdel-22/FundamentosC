using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticasVistasParcialesCasa.Models
{
    public class Mensaje
    {
        public int Id { get; set; }
        [Required]

        public string Username { get; set; }
        [Required]

        public string Texto { get; set; }

        public DateTime Fecha { get; set; }
    }
}
