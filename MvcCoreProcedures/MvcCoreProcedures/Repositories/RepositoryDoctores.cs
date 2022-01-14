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
    public class RepositoryDoctores
    {
        private EnfermosContext context;

        public RepositoryDoctores(EnfermosContext context) {

            this.context = context;
        }

        public List<Doctor> GetDoctores() {

            List<Doctor> Doctores = this.context.Doctores.ToList();
            return Doctores;
        }

        public List<string> GetEspecialidaes() {

            using (DbCommand com = this.context.Database.GetDbConnection().CreateCommand()) {

                string sql = "GET_ESPECIALIDADES";

                com.CommandType = System.Data.CommandType.StoredProcedure;
                com.CommandText = sql;

                com.Connection.Open();
                DbDataReader reader = com.ExecuteReader();

                List<string> Especialidades = new List<string>();

                while (reader.Read()) {

                    string especialidad = reader["ESPECIALIDAD"].ToString();
                    Especialidades.Add(especialidad);
                }

                reader.Close();
                com.Connection.Close();
                return Especialidades;
            }
                

        }

        public void IncrementarSalario(string especialidad,int incremento) {

            string sql = "INCREMENTAR_SALARIO @INCREMENTO,@ESPECIALIDAD";

            SqlParameter pamIn = new SqlParameter("@INCREMENTO", incremento);
            SqlParameter pamEsp = new SqlParameter("@ESPECIALIDAD", especialidad);

            var consulta = this.context.Database.ExecuteSqlRaw(sql, pamIn, pamEsp);
           
        }

        public List<Doctor> FindDoctores(string especialidad) {

            string sql = "FIND_DOCTORES_ESPECIALIDAD @ESPECIALIDAD";
            SqlParameter pamEsp = new SqlParameter("@ESPECIALIDAD", especialidad);

            var consulta = this.context.Doctores.FromSqlRaw(sql, pamEsp);

            List<Doctor> doctores = consulta.AsEnumerable().ToList();

            return doctores;
        }
    }
}
