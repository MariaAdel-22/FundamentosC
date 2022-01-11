using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Models
{
    /*Ahora vamos a mapear para que vaya a la tabla hospital*/

    [Table("HOSPITAL")]
    public class Hospital
    {
        /*Que en la base de datos no haya clave no significa que aquí no podamos ponerla*/
        [Key]
        [Column("HOSPITAL_COD")]
        public int IdHospital { get; set; }
        
        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("DIRECCION")]
        public string Direccion { get; set; }

        [Column("TELEFONO")]
        public string Telefono { get; set; }

        [Column("NUM_CAMA")]
        public int Camas { get; set; }
    }
}
