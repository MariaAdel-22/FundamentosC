using MvcEmpleadosReto.Data;
using MvcEmpleadosReto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEmpleadosReto.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;

        public RepositoryEmpleados() {

            this.context = new EmpleadosContext();
        }

        public List<Empleado> GetEmpleados() {

            var consulta = from datos in this.context.Empleados select datos;
            return consulta.ToList();
        
        }
    }
}