using ProyectoPracticaEnfermosEF.Data;
using ProyectoPracticaEnfermosEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoPracticaEnfermosEF.Repositories
{
    public class RepositoryEnfermos
    {
        private EnfermosContext context;

        public RepositoryEnfermos(EnfermosContext context) {

            this.context = context;
        }

        public List<Enfermo> GetEnfermos() {

            var consulta = from datos in this.context.Enfermos select datos;

            return consulta.ToList();
        }
    }
}
