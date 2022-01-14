using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreProcedures.Data;
using MvcCoreProcedures.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProcedures.Repositories
{
    public class RepositoryEnfermos
    {
        private EnfermosContext context;
        public RepositoryEnfermos(EnfermosContext context) {

            this.context = context;
        }

        public List<Enfermo> GetEnfermos() {

            //PARA LLAMAR A PROCEDIMIENTOS SELECT DEBEMOS EXTRAER LA CONEXION DE NUESTRO CONTEXT. SE UTILIZAN OBJETOS A LA ANTIGUA DE ADO

            using (DbCommand com = this.context.Database.GetDbConnection().CreateCommand()) {

                string sql = "GET_ENFERMOS";
                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.CommandText = sql;

                com.Connection.Open();
                DbDataReader reader = com.ExecuteReader();

                List<Enfermo> enfermos = new List<Enfermo>();

                while (reader.Read()) {

                    Enfermo enf = new Enfermo();

                    enf.Inscripcion = int.Parse(reader["INSCRIPCION"].ToString());
                    enf.Apellido = reader["APELLIDO"].ToString();
                    enf.Direccion = reader["DIRECCION"].ToString();
                    enf.Fecha = DateTime.Parse(reader["FECHA_NAC"].ToString());
                    enf.Sexo = reader["S"].ToString();
                    enf.Seguridad_Social = reader["NSS"].ToString();

                    enfermos.Add(enf);
                }
                reader.Close();
                com.Connection.Close();
                return enfermos;
            }
        }

        public Enfermo FindEnfermo(int inscripcion) {

            string sql = "FIND_ENFERMO @INSCRIPCION";

            SqlParameter pamsinc=new SqlParameter("@INSCRIPCION", inscripcion);
            var consulta = this.context.Enfermos.FromSqlRaw(sql, pamsinc);

            Enfermo enf = consulta.AsEnumerable().FirstOrDefault();

            return enf;
        }

        public void DeleteEnfermo(int inscripcion) {

            string sql = "DELETE_ENFERMO @INSCRIPCION";
            SqlParameter pamIns = new SqlParameter("@INSCRIPCION", inscripcion);
            this.context.Database.ExecuteSqlRaw(sql, pamIns);
        }
    }
}
