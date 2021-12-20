using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProyectoMvcDatosOld.Models;

namespace ProyectoMvcDatosOld.Data
{
    public class DepartamentosContext
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public DepartamentosContext() {


            string cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

        }

        public List<Departamento> GetDepartamentos() {

            List<Departamento> departamentos = new List<Departamento>();

            string sql = "SELECT * FROM DEPT";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                Departamento dep = new Departamento();

                dep.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                dep.Nombre = this.reader["DNOMBRE"].ToString();
                dep.Localidad = this.reader["LOC"].ToString();

                departamentos.Add(dep);
            }

            this.reader.Close();
            this.connect.Close();

            return departamentos;
        }

        public Departamento FindDepartamento(int dept_no) {

            Departamento dep = new Departamento();

            string sql = "SELECT * FROM DEPT WHERE DEPT_NO=@DEPT_NO";

            this.com.Parameters.AddWithValue("@DEPT_NO", dept_no);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                dep.IdDepartamento = int.Parse(this.reader["DEPT_NO"].ToString());
                dep.Nombre = this.reader["DNOMBRE"].ToString();
                dep.Localidad = this.reader["LOC"].ToString();

            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();

            return dep;

        }

        public int InsertarDepartamento(int id, string nombre, string local) {

            string sql = "INSERT INTO DEPT VALUES(@ID,@NOMBRE,@LOCALIDAD)";

            this.com.Parameters.AddWithValue("@ID", id);
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@LOCALIDAD", local);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            int ins=this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();

            return ins;
        }

        public int UpdateDepartamento(int id, string nombre, string localidad) {

            string sql = "UPDATE DEPT SET DNOMBRE=@NOMBRE,LOC=@LOCALIDAD WHERE DEPT_NO=@DEPT_NO";

            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@LOCALIDAD", localidad);
            this.com.Parameters.AddWithValue("@DEPT_NO", id);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            int res = this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();

            return res;
        }

        public int DeleteDepartamento(int id) {

            string sql = "DELETE FROM DEPT WHERE DEPT_NO=@ID";

            this.com.Parameters.AddWithValue("@ID", id);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            int res=this.com.ExecuteNonQuery();

            this.connect.Close();

            return res;
        }
    }
}
