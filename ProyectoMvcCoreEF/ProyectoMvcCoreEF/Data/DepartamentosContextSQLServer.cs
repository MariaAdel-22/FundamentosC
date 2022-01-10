using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoMvcCoreEF.Models;

namespace ProyectoMvcCoreEF.Data
{
    public class DepartamentosContextSQLServer
    {
        private DataTable tabla;
        private SqlDataAdapter ad;
        private String CadenaConexion;
        private SqlConnection connect;
        private SqlCommand com;

        public DepartamentosContextSQLServer(string cadenaconexion) {

            this.CadenaConexion = cadenaconexion;

            this.connect = new SqlConnection(this.CadenaConexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            this.CargarDatos();
        }

        public void InsertarDepartamento(int numero, string nombre, string localidad) {

            string sql = "INSERT INTO DEPT VALUES (@NUMERO,@NOMBRE,@LOCALIDAD)";

            this.com.Parameters.AddWithValue("@NUMERO", numero);
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@LOCALIDAD", localidad);

            this.com.CommandText = sql;
            this.com.CommandType = CommandType.Text;

            this.connect.Open();
            this.com.ExecuteNonQuery();
            this.connect.Close();

            this.com.Parameters.Clear();
            this.CargarDatos();
        }

        public void CargarDatos() {

            this.ad = new SqlDataAdapter("SELECT * FROM DEPT", this.CadenaConexion);
            this.tabla = new DataTable();
            this.ad.Fill(this.tabla);
        }

        public List<Departamento> GetDepartamentos() {

            List<Departamento> Departamentos = new List<Departamento>();
            var consulta = from datos in this.tabla.AsEnumerable() select datos;

            foreach (var fila in consulta) {

                Departamento dep = new Departamento();

                dep.IdDepartamento = fila.Field<int>("DEPT_NO");
                dep.Nombre = fila.Field<string>("DNOMBRE");
                dep.Localidad = fila.Field<string>("LOC");

                Departamentos.Add(dep);
            }
            return Departamentos;
        }
    }
}
