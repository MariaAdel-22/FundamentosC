using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Models
{
    public interface IRepositoryEmpleados
    {
        List<Empleado> GetEmpleados();
        Empleado FindEmpleado(int id);
        void UpdateSalarioEmpleado(int idempleado, int incremento);
        void DeleteEmpleado(int id);
    }
}
