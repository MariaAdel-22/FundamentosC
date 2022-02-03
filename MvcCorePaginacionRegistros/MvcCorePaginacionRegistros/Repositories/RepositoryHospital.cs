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

        //VAMOS A HACER UN MÉTODO QUE DEVUELVA EL NÚMERO DE REGISTROS
        public int GetNumeroRegistros() {

            return this.context.VistaDepartamentos.Count();
        }

        public VistaDepartamentoRegistro GetVistaDepartamento(int posicion) {

            var consulta = from datos in this.context.VistaDepartamentos where datos.Posicion == posicion select datos;

            return consulta.FirstOrDefault();
        }

        public List<VistaDepartamentoRegistro> GetGrupoVistaDepartamento(int posicion) {

            var consulta = from datos in this.context.VistaDepartamentos where datos.Posicion >= posicion && datos.Posicion < (posicion + 2) select datos;

            return consulta.ToList();
        }
    }
}
