using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcEmpleadosReto.Models
{
    public interface IRepository
    {
        List<Empleado> GetEmpleados();
    }
}
