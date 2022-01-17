using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProcedures.Models
{
    [Table("EMPLEADOS_DEPARTAMENTOS")]
    public class VistaEmpleado
    {
        /*hay que crear el modelo de la vista que hay en onenote*/
        [Key]
        [Column("EMP_NO")]
        public int CodigoEmpleado { get; set; }

        [Column("APELLIDO")]
        public string Apellidos { get; set; }

        [Column("OFICIO")]
        public string Oficio { get; set; }

        [Column("DEPARTAMENTO")]
        public string Departamento { get; set; }

        [Column("LOCALIDAD")]
        public string Localidad { get; set; }
    }
}
