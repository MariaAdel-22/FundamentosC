using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Models
{
    [Table("DEPT")]
    public class Departamento
    {
        [Key]
        [Column("DEPT_NO")]

        //Esta instrucción se pondría en el caso de que tuvieramos una clave Identity en la tabla (auto)
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDepartamento { get; set; }

        [Column("DNOMBRE")]
        public String Nombre { get; set; }

        [Column("LOC")]
        public string Localidad { get; set; }
    }
}
