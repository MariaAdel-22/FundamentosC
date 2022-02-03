using MvcCorePaginacionRegistros.Data;
using MvcCorePaginacionRegistros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCorePaginacionRegistros.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context) {
            this.context = context;
        }

        public VistaDepartamentoRegistro GetVistaDepartamento(int posicion) {

            var consulta = from datos in this.context.VistaDepartamentos where datos.Posicion == posicion select datos;

            return consulta.FirstOrDefault();
        }
    }
}
