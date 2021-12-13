using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNet.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

#region PROCEDIMIENTOS

/*
 CREATE PROCEDURE GET_DEPARTAMENTO (@NOMBRE NVARCHAR(50))
AS
	DECLARE @COD_DEPT INT

	SELECT @COD_DEPT=DEPT_NO FROM DEPT WHERE DNOMBRE=@NOMBRE

	SELECT * FROM DEPT WHERE DEPT_NO=@COD_DEPT
GO
 */

#endregion

namespace AdoNet.Context
{
    public class DepartamentoContext
    {
        private SqlConnection connect;
        private SqlCommand com;
        private SqlDataReader reader;


        public DepartamentoContext() {

            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();

            string cadenaconexion = config["CadenaHospital"];

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();

            this.com.Connection = this.connect;
        }

        public List<Departamento> MostrarDepartamentos() {

            List<Departamento> listaDepartamentos = new List<Departamento>();

            string sql = "SELECT * FROM DEPT";

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                Departamento dep = new Departamento();

                dep.Numero = int.Parse(this.reader["DEPT_NO"].ToString());
                dep.Nombre = this.reader["DNOMBRE"].ToString();
                dep.Localidad = this.reader["LOC"].ToString();
 
                listaDepartamentos.Add(dep);
            }

            this.reader.Close();
            this.connect.Close();

            return listaDepartamentos;
        }

        public Departamento MostrarDepartamento(string nombre) {

            Departamento dep = new Departamento();
            
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "GET_DEPARTAMENTO";

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                dep.Numero = int.Parse(this.reader["DEPT_NO"].ToString());
                dep.Nombre = this.reader["DNOMBRE"].ToString();
                dep.Localidad = this.reader["LOC"].ToString();
            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();

            return dep;
        }

        public void InsertarDepartamento(Departamento dep) {

            string sql = "INSERT INTO DEPT VALUES (@NUMERO,@NOMBRE,@LOCALIDAD)";

            this.com.Parameters.AddWithValue("@NUMERO", dep.Numero);
            this.com.Parameters.AddWithValue("@NOMBRE", dep.Nombre);
            this.com.Parameters.AddWithValue("@LOCALIDAD", dep.Localidad);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();
        }

        public void ModificarDepartamento(Departamento dep) {

            string sql = "UPDATE DEPT SET DNOMBRE=@NOMBRE, LOC=@LOCALIDAD WHERE DEPT_NO=@DEPTNO";

            this.com.Parameters.AddWithValue("@DEPTNO",dep.Numero);
            this.com.Parameters.AddWithValue("@NOMBRE", dep.Nombre);
            this.com.Parameters.AddWithValue("@LOCALIDAD", dep.Localidad);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();
        }

        public void EliminarDepartamento(int dept_no) {

            string sql = "DELETE FROM DEPT WHERE DEPT_NO=@DEPTNO";

            this.com.Parameters.AddWithValue("@DEPTNO", dept_no);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();
        }
    }
}
