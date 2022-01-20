using Microsoft.EntityFrameworkCore;
using MvcCoreMultiplesBBDD.Data;
using MvcCoreMultiplesBBDD.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Repositories
{
    public class RepositoryEmpleadosMySQL : IRepositoryEmpleados
    {

        private HospitalContext context;

        public RepositoryEmpleadosMySQL(HospitalContext context) {

            this.context = context;
        }

        public void DeleteEmpleado(int id)
        {
            string sql = "DELETE_EMPLEADO(@ID)";

            MySqlParameter pamId = new MySqlParameter("@ID", id);

            var consulta = this.context.Database.ExecuteSqlRaw(sql,pamId);
        }

        public Empleado FindEmpleado(int id)
        {
            string sql = "FIND_EMPLEADO(@ID)";

            MySqlParameter pamId = new MySqlParameter("@ID",id);

            var consulta = this.context.Empleados.FromSqlRaw(sql,pamId);

            return consulta.AsEnumerable().First();
        }

        public List<Empleado> GetEmpleados()
        {
            string sql = "ALL_EMPLEADOS";

            var consulta = this.context.Empleados.FromSqlRaw(sql);

            return consulta.ToList();
        }

        public void UpdateSalarioEmpleado(int idempleado, int incremento)
        {
            string sql = "UPDATE_SALARIO_EMPLEADO(@ID,@INCREMENTO)";

            MySqlParameter pamId = new MySqlParameter("@ID",idempleado);
            MySqlParameter pamInc = new MySqlParameter("@INCREMENTO", incremento);

            var consulta = this.context.Database.ExecuteSqlRaw(sql,pamId,pamInc);
        }
    }
}
