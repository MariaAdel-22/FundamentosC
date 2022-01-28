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

        public Empleado FindEmpleado(int codigoEmpleado) {

            var consulta = from datos in this.context.Empleados.AsEnumerable() where datos.CodigoEmpleado == codigoEmpleado select datos;

            return consulta.FirstOrDefault();
        }

        public List<Empleado> EmpleadosPorColeccionId(List<int>idEmpleados) {

            //Cuando usamos busqueda en coleccion se utiliza el metodo Contains, entonces lo que le estamos diciendo es que busque, dentro de listado de tipo int, si coincide algún valor con id de empleado

            var consulta = from datos in this.context.Empleados.AsEnumerable()  where idEmpleados.Contains(datos.CodigoEmpleado) select datos;

            if (consulta.Count() == 0) {

                return null;
            }
            return consulta.ToList();
        }
    }
}
