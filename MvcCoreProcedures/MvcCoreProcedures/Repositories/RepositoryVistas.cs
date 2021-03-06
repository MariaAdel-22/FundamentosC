using MvcCoreProcedures.Data;
using MvcCoreProcedures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProcedures.Repositories
{
    public class RepositoryVistas
    {
        private EnfermosContext context;

        public RepositoryVistas(EnfermosContext context) {

            this.context = context;
        }

        public List<VistaEmpleado> GetVistaEmpleados() {

            var consulta = from datos in this.context.VistaEmpleados select datos;

            return consulta.ToList();
        }
    }
}
