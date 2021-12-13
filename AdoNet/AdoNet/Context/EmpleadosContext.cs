using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using AdoNet.Models;

namespace AdoNet.Context
{
    public class EmpleadosContext
    {
        private SqlConnection connect;
        private SqlCommand com;
        private SqlDataReader reader;

        public EmpleadosContext(){

            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            String cadenaconexion = config["CadenaHospital"];

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;
        }

        public List<String> GetOficios() {

            List<String> listadoOficios = new List<string>();

            string sql = "SELECT DISTINCT OFICIO FROM EMP";

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                string oficio = this.reader["OFICIO"].ToString();
                listadoOficios.Add(oficio);
            }

            this.reader.Close();
            this.connect.Close();

            return listadoOficios;
        }

        public List<Empleado> GetEmpleadosOficio(string oficio) {

            List<Empleado> listaEmpleados = new List<Empleado>();

            string sql = "SELECT * FROM EMP WHERE OFICIO=@OFICIO";

            this.com.Parameters.AddWithValue("@OFICIO",oficio);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                Empleado emp = new Empleado();

                emp.IdEmpleado = int.Parse(this.reader["EMP_NO"].ToString());
                emp.Apellido = this.reader["APELLIDO"].ToString();
                emp.Oficio = this.reader["OFICIO"].ToString();
                emp.Salario = int.Parse(this.reader["SALARIO"].ToString());

                listaEmpleados.Add(emp);
            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();

            return listaEmpleados;
        }
    }
}
