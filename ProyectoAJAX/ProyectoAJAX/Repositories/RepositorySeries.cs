using ProyectoAJAX.Data;
using ProyectoAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAJAX.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;

        public RepositorySeries(SeriesContext context) {

            this.context = context;
        }

        public List<Serie> GetSeries() {

            var consulta = from datos in this.context.Series select datos;

            return consulta.ToList();
        }

        public Serie FindSerie(int codigoSerie) {

            var consulta = from datos in this.context.Series where datos.CodigoSerie == codigoSerie select datos;

            return consulta.SingleOrDefault();
        }
    }
}
