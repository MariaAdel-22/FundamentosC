using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcHospitalCrudLinq.Models;
using System.Data.SqlClient;
using System.Data;

#region PROCEDIMIENTOS

/*
 CREATE PROCEDURE INSERTAR_HOSPITAL (@HOSPITAL_COD NVARCHAR(50), @NOMBRE NVARCHAR(50),@DIRECCION NVARCHAR(50), @TELEFONO NVARCHAR(50), @NUM_CAMA NVARCHAR(50))
AS
 INSERT INTO HOSPITAL VALUES (@HOSPITAL_COD,@NOMBRE,@DIRECCION,@TELEFONO,@NUM_CAMA)
GO
 */

/*
 CREATE PROCEDURE MODIFICAR_HOSPITAL (@HOSPITAL_COD NVARCHAR(50), @NOMBRE NVARCHAR(50),@DIRECCION NVARCHAR(50), @TELEFONO NVARCHAR(50), @NUM_CAMA NVARCHAR(50))
AS
 UPDATE HOSPITAL SET NOMBRE=@NOMBRE, DIRECCION=@DIRECCION, TELEFONO=@TELEFONO, NUM_CAMA=@NUM_CAMA WHERE HOSPITAL_COD=@HOSPITAL_COD
GO
 */

/*
 CREATE PROCEDURE ELIMINAR_HOSPITAL (@HOSPITAL_COD NVARCHAR(50))
AS
 DELETE FROM HOSPITAL WHERE HOSPITAL_COD=@HOSPITAL_COD
GO
 */
#endregion

namespace MvcHospitalCrudLinq.Data
{
    public class HospitalContext
    {

        private SqlDataAdapter adpH;
        private DataTable tabla;

        private SqlConnection connect;
        private SqlCommand com;
   
        public HospitalContext() {

            string cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            this.RefreshTabla();
        }

        private void RefreshTabla() {

            string sql = "SELECT * FROM HOSPITAL";

            this.adpH = new SqlDataAdapter(sql, this.connect);
            this.tabla = new DataTable();

            this.adpH.Fill(this.tabla);
        }

        public List<Hospital> GetHospitales() {

            List<Hospital> hospitales = new List<Hospital>();

            var consulta = from datos in this.tabla.AsEnumerable() select datos;

            foreach (var row in consulta) {

                Hospital hosp = new Hospital();

                hosp.Direccion = row.Field<string>("DIRECCION");
                hosp.Hospital_Cod = row.Field<string>("HOSPITAL_COD");
                hosp.Nombre = row.Field<string>("NOMBRE");
                hosp.Num_Cama = row.Field<string>("NUM_CAMA");
                hosp.Telefono = row.Field<string>("TELEFONO");

                hospitales.Add(hosp);
            }

            this.RefreshTabla();

            return hospitales;
        }

        public int InsertarHospital(string hospital_cod, string nombre, string direccion, string telefono,string num_cama) {

            this.com.Parameters.AddWithValue("@HOSPITAL_COD",hospital_cod);
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@DIRECCION",direccion);

            this.com.Parameters.AddWithValue("@TELEFONO",telefono);
            this.com.Parameters.AddWithValue("@NUM_CAMA", num_cama);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "INSERTAR_HOSPITAL";

            this.connect.Open();
           int res= this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();

            this.RefreshTabla();

            return res;

        }

        public int ModificarHospital(string hospital_cod, string nombre, string direccion, string telefono, string num_cama) {

            this.com.Parameters.AddWithValue("@HOSPITAL_COD", hospital_cod);
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@DIRECCION", direccion);

            this.com.Parameters.AddWithValue("@TELEFONO", telefono);
            this.com.Parameters.AddWithValue("@NUM_CAMA", num_cama);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "MODIFICAR_HOSPITAL";

            this.connect.Open();
            int res = this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();
            this.RefreshTabla();

            return res;
        }

        public Hospital BuscarHospital(string hospital_cod) {

            Hospital hosp = new Hospital();

            var consulta = from datos in this.tabla.AsEnumerable() where datos.Field<string>("HOSPITAL_COD") == hospital_cod select datos;

            foreach (var row in consulta) {

                hosp.Direccion = row.Field<string>("DIRECCION");
                hosp.Hospital_Cod = row.Field<string>("HOSPITAL_COD");
                hosp.Nombre = row.Field<string>("NOMBRE");
                hosp.Num_Cama = row.Field<string>("NUM_CAMA");
                hosp.Telefono = row.Field<string>("TELEFONO");
                
            }

            return hosp;
        }

        public int EliminarHospital(string hospital_cod) {

            this.com.Parameters.AddWithValue("@HOSPITAL_COD", hospital_cod);

            this.com.CommandType = System.Data.CommandType.StoredProcedure;
            this.com.CommandText = "ELIMINAR_HOSPITAL";

            this.connect.Open();
            int res = this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();

            this.RefreshTabla();

            return res;
        }
    }
}
