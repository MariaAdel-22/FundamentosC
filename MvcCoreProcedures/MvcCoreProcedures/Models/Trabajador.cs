using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProcedures.Models
{
    [Table("VISTA_TRABAJADORES")]
    public class Trabajador
    {
        [Key]
        [Column("ID_TRABAJADOR")]
        public int IdTrabajador { get; set; }

        [Column("APELLIDO")]
        public string Apellido { get; set; }

        [Column("SALARIO")]
        public int Salario { get; set; }

        [Column("OFICIO")]
        public string Oficio { get; set; }
    }
}
