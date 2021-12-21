using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using NetCoreLinqSQL.Models;

namespace NetCoreLinqSQL.Data
{
    public class EnfermosContext
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        SqlDataAdapter adenf;
        private DataTable tabla;

        public EnfermosContext() {

            //Para las consultas de accion
            string cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();

            this.com.Connection = this.connect;
            this.RefreshTabla();
        }

        //Es importante tener este método para refrescar los datos de la tabla ya que no llama de nuevo a la consulta
        private void RefreshTabla() {

            string sql = "SELECT * FROM ENFERMO";

            this.adenf = new SqlDataAdapter(sql, this.connect);
            this.tabla = new DataTable();
            this.adenf.Fill(tabla);
        }

        public List<Enfermo> GetEnfermos() {

            List<Enfermo> Enfermos = new List<Enfermo>();

            var consulta = from datos in this.tabla.AsEnumerable() select datos;

            foreach (var row in consulta) {

                Enfermo enf = new Enfermo();

                enf.Apellido = row.Field<string>("APELLIDO");
                enf.Direccion = row.Field<string>("DIRECCION");
                enf.Fecha_nac = row.Field<DateTime>("FECHA_NAC");
                enf.Inscripcion = row.Field<string>("INSCRIPCION");
                enf.NSS = row.Field<string>("NSS");
                enf.S = Char.Parse(row.Field<string>("S"));

                Enfermos.Add(enf);
            }

            return Enfermos;
        }


        public int EliminarEnfermo(int inscripcion) {

            this.com.Parameters.AddWithValue("@INSCRIPCION", inscripcion);

            string sql = "DELETE FROM ENFERMO WHERE INSCRIPCION=@INSCRIPCION";

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            int res=this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();
            this.RefreshTabla();

            return res;
        }
    }
}
