using MvcSeguridadEmpleados.Data;
using MvcSeguridadEmpleados.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeguridadEmpleados.Repositories
{
    public class RepositoryEmpleado
    {
        private EmpleadosContext context;

        public RepositoryEmpleado(EmpleadosContext context) {

            this.context = context;
        }

        public List<Empleado> GetEmpleados() {

            return this.context.Empleados.ToList();
        }

        public Empleado FindEmpleado(string apellido, int codigoEmpleado) {

            var consulta = from datos in this.context.Empleados where datos.Apellido == apellido && datos.IdEmpleado == codigoEmpleado 
                           select datos;

            return consulta.SingleOrDefault();
        }

        public List<Empleado> GetEmpleadosDepartamento(int iddepartamento) {

            var consulta = from datos in this.context.Empleados where datos.Departamento == iddepartamento select datos;

            return consulta.ToList();
        }
    }
}
