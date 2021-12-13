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
    public class HospitalContext
    {
        private SqlConnection connect;
        private SqlCommand com;
        private SqlDataReader reader;

        public HospitalContext() {

            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();

            string cadenaconexion = config["hospitalCasa"];

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

        }

        public List<Hospital> CargarHospitales() {

            List<Hospital> hospitales = new List<Hospital>();

            string sql = "SELECT * FROM HOSPITAL";

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                Hospital hosp = new Hospital();

                hosp.Hospital_cod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hosp.Nombre = this.reader["NOMBRE"].ToString();
                hosp.Direccion = this.reader["DIRECCION"].ToString();
                hosp.Telefono = this.reader["TELEFONO"].ToString();
                hosp.Num_camas =int.Parse(this.reader["NUM_CAMA"].ToString());

                hospitales.Add(hosp);
            }

            this.reader.Close();
            this.connect.Close();

            return hospitales;
        }

        public List<Plantilla> CargarPlantilla(int hospital_cod) {

            List<Plantilla> plantillas = new List<Plantilla>();

            string sql = "SELECT * FROM PLANTILLA WHERE HOSPITAL_COD=@CODHOSPITAL";

            this.com.Parameters.AddWithValue("@CODHOSPITAL", hospital_cod);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                Plantilla plan = new Plantilla();

                plan.Hospital_cod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                plan.Empleado_no = int.Parse(this.reader["EMPLEADO_NO"].ToString());
                plan.Apellido = this.reader["APELLIDO"].ToString();
                plan.Funcion = this.reader["FUNCION"].ToString();
                plan.Salario = int.Parse(this.reader["SALARIO"].ToString());
                plan.Sala_cod = int.Parse(this.reader["SALA_COD"].ToString());
                plan.T = char.Parse(this.reader["T"].ToString());

                plantillas.Add(plan);

            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();

            return plantillas;
        }


        public List<Plantilla> CargarPlantillaChck(List<int>Hospital_cod) {

            List<Plantilla> plantillas = new List<Plantilla>();

            string sql = "SELECT * FROM PLANTILLA WHERE HOSPITAL_COD IN (";
   
            foreach (int cod in Hospital_cod) {

                sql+=cod + ",";
            }

            sql=sql.Trim(',');
            sql +=")";

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {

                Plantilla plan = new Plantilla();

                plan.Hospital_cod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                plan.Empleado_no = int.Parse(this.reader["EMPLEADO_NO"].ToString());
                plan.Apellido = this.reader["APELLIDO"].ToString();
                plan.Funcion = this.reader["FUNCION"].ToString();
                plan.Salario = int.Parse(this.reader["SALARIO"].ToString());
                plan.Sala_cod = int.Parse(this.reader["SALA_COD"].ToString());
                plan.T = char.Parse(this.reader["T"].ToString());

                plantillas.Add(plan);

            }

            this.reader.Close();
            this.connect.Close();

            return plantillas;
        }
    }
}
