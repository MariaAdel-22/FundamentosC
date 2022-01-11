using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProyectoMvcCoreEF.Models;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyectoMvcCoreEF.Data
{
    public class DepartamentosContextMySQL:IDepartamentosContext
    {
        private MySqlDataAdapter ad;
        private DataTable tabla;
        private MySqlConnection connect;
        private MySqlCommand com;
        private string CadenaConexion;

        public DepartamentosContextMySQL(string cadenaconexion) {

            this.CadenaConexion = cadenaconexion;
            this.CargarDatos();

            this.connect = new MySqlConnection(this.CadenaConexion);
            this.com = new MySqlCommand();
            this.com.Connection = this.connect;
        }

        public void CargarDatos() {

            this.ad = new MySqlDataAdapter("SELECT * FROM DEPT",this.CadenaConexion);
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
    }
}
