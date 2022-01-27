using MvcCoreEmpleadosSession.Data;
using MvcCoreEmpleadosSession.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEmpleadosSession.Repositories
{
    public class RepositoryEmpleado
    {
        private EmpleadosContext context;
       

        public RepositoryEmpleado(EmpleadosContext context) {

            this.context = context;
        }

        public List<Empleado> GetEmpleado() {

            var consulta = from datos in this.context.Empleados.AsEnumerable() select datos;

            return consulta.ToList();
        }
    }
}
