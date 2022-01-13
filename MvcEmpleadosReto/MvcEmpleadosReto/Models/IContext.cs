using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcEmpleadosReto.Models
{
   public interface IContext
    {
        DbSet<Empleado> empleados { get; set; }
    }
}
