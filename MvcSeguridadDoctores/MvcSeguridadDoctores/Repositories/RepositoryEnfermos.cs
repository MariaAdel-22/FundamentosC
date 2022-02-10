using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcSeguridadDoctores.Data;
using MvcSeguridadDoctores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeguridadDoctores.Repositories
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

        public Doctor FindDoctor(string nombre, string codigo) {

            var consulta = from datos in this.context.Doctores where datos.Apellido == nombre && datos.CodigoDoctor == int.Parse(codigo) select datos;

            return consulta.SingleOrDefault();
        }

        public Enfermo FindEnfermo(int codigoEnfermo) {

            var consulta = from datos in this.context.Enfermos where datos.Inscripcion == codigoEnfermo select datos;

            return consulta.SingleOrDefault();
        }

        public void EliminarEnfermo(int codigoEnfermo) {

            string sql = "DELETE_ENFERMO @INSCRIPCION";

            SqlParameter parmInsc = new SqlParameter("@INSCRIPCION",codigoEnfermo);

            this.context.Database.ExecuteSqlRaw(sql,parmInsc);
        }
    }
}
