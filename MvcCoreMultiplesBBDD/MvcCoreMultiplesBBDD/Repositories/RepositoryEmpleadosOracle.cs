using Microsoft.EntityFrameworkCore;
using MvcCoreMultiplesBBDD.Data;
using MvcCoreMultiplesBBDD.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Repositories
{
    public class RepositoryEmpleadosOracle:IRepositoryEmpleados
    {
        private HospitalContext context;

        public RepositoryEmpleadosOracle(HospitalContext context) {

            this.context = context;
        }


        /*public List<Empleado> GetEmpleados()
        {
            var consulta = from datos in this.context.Empleados select datos;
            return consulta.ToList();
        }*/

        public List<Empleado> GetEmpleados() {

            string sql = "BEGIN SP_ALL_EMPLEADOS(:EMPLEADOS); END;";

            OracleParameter pamEmpleados = new OracleParameter();

            pamEmpleados.ParameterName = "EMPLEADOS";
            pamEmpleados.Value = null;

            pamEmpleados.Direction = System.Data.ParameterDirection.Output;
            pamEmpleados.OracleDbType = OracleDbType.RefCursor;

            var consulta = this.context.Empleados.FromSqlRaw(sql, pamEmpleados);

            //AL SER UN CURSOR DE SALIDA, DENTRO DE LA CONSULTA ESTÁN LOS DATOS DIRECTAMENTE.

            return consulta.ToList();
        }

        public Empleado FindEmpleado(int id)
        {
            return this.context.Empleados.SingleOrDefault(x => x.IdEmpleado == id);
        }

        public void DeleteEmpleado(int id)
        {
            //EN ORACLE LOS PARAMETROS DE LA LLAMADA SE DENOMINAN COM :PARAMETRO

            string sql = "BEGIN" + " SP_DELETE_EMPLEADO(:IDEMPLEADO);" + " END;";

            OracleParameter paramId = new OracleParameter("IDEMPLEADO",id);

            this.context.Database.ExecuteSqlRaw(sql,paramId);
        }

       

        public void UpdateSalarioEmpleado(int idempleado, int incremento)
        {
            string sql = "BEGIN " + "SP_UPDATE_SALARIO_EMP(:IDEMPLEADO, :INCREMENTO); " + "END;";

            OracleParameter pamId = new OracleParameter("IDEMPLEADO", idempleado);
            OracleParameter pamInc = new OracleParameter("INCREMENTO", incremento);

            this.context.Database.ExecuteSqlRaw(sql,pamId,pamInc);
        }
    }
}
