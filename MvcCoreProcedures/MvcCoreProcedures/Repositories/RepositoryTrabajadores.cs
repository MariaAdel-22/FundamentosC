using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using MvcCoreProcedures.Data;
using MvcCoreProcedures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreProcedures.Repositories
{
    public class RepositoryTrabajadores
    {
        private EnfermosContext context;

        public RepositoryTrabajadores(EnfermosContext context) {

            this.context = context;
        }

        public List<string> GetOficios() {

            var consulta = (from datos in this.context.Trabajadores select datos.Oficio).Distinct();

            return consulta.ToList();
        }

        public ResumenTrabajadores GetResumenTrabajadores(string oficio) {

            //Los parametros de salida se deben indicar en la llamada con la palabra out

            string sql = "TRABAJADORES_OFICIO @OFICIO,@MEDIA out,@SUMA out";

            SqlParameter paramofi = new SqlParameter("@OFICIO", oficio);

            //Todos los parametros deben tener un valor por defecto en la llamada

            SqlParameter paramMedia = new SqlParameter("@MEDIA", -1);
            paramMedia.Direction = System.Data.ParameterDirection.Output;

            SqlParameter paramSalario = new SqlParameter("@SUMA", -1);
            paramSalario.Direction = System.Data.ParameterDirection.Output;

            //Ejecutamos el procedimiento 

            var consulta = this.context.Trabajadores.FromSqlRaw(sql,paramofi, paramMedia, paramSalario);

            ResumenTrabajadores resumen = new ResumenTrabajadores();

            resumen.Trabajadores = consulta.ToList();
            resumen.SumaSalarial = int.Parse(paramSalario.Value.ToString());
            resumen.MediaSalarial = int.Parse(paramMedia.Value.ToString());

            return resumen;
        }
    }
}
