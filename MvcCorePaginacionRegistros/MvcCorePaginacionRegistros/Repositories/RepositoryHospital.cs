using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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

        //Ref significa que así asignamos una variable de salida en el método
        public List<Departamento> GetGrupoDepartamentos(int posicion, ref int numeroregistros) {

            string sql = "SP_PAGINAR_GRUPO_DEPARTAMENTOS @POSICION,@REGISTROS out";

            SqlParameter pamPos = new SqlParameter("POSICION",posicion);
            SqlParameter pamRegis = new SqlParameter("@REGISTROS", -1);
            pamRegis.Direction = System.Data.ParameterDirection.Output;

            var consulta = this.context.Departamentos.FromSqlRaw(sql, pamPos,pamRegis);
           numeroregistros = (int)pamRegis.Value;

            List <Departamento> departamentos= consulta.ToList();
            return departamentos;
        }

        public List<Empleado> GetGrupoEmpleados(int posicion,string oficio,ref int numeroRegistros) {

            string sql = "PAGINACION_GRUPO_EMPLEADOS_OFICIO @POSICION,@OFICIO,@REGISTRO out";

            SqlParameter paramPos = new SqlParameter("@POSICION", posicion);
            SqlParameter paramOf = new SqlParameter("@OFICIO",oficio);
            SqlParameter paramNumReg = new SqlParameter("@REGISTRO",-1);
            paramNumReg.Direction = System.Data.ParameterDirection.Output;

            var consulta = this.context.Empleados.FromSqlRaw(sql,paramPos,paramOf,paramNumReg);
            
            List<Empleado> Empleados = consulta.ToList();
            numeroRegistros = (int)paramNumReg.Value;

            return Empleados;
        }
    }
}
