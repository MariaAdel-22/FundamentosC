using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

#region PROCEDIMIENTOS

/*
 CREATE PROCEDURE MOSTRAR_DATOS (@DATO NVARCHAR(50))
AS
	IF(UPPER(@DATO) = 'HOSPITAL')
	BEGIN
		SELECT COLUMN_NAME AS COLUMNA FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='HOSPITAL';
	END
	ELSE

	IF(UPPER(@DATO)='SALA')
	BEGIN
		SELECT COLUMN_NAME AS COLUMNA FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='SALA';
	END
	ELSE

	IF(UPPER(@DATO)='ENFERMO')
	BEGIN
		SELECT COLUMN_NAME AS COLUMNA FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='ENFERMO';
	END
GO
*/
#endregion

namespace EjerciciosExtra.Context
{
    public class HospitalContext
    {
		SqlConnection connect;
		SqlCommand com;
		SqlDataReader reader;

		public HospitalContext() {

			IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json");
			IConfigurationRoot config = builder.Build();
			string cadenaconexion = config["Hospital"];

			this.connect = new SqlConnection(cadenaconexion);
			this.com = new SqlCommand();
			this.com.Connection = this.connect;

		}

        public List<String>CargarColumnas(List<string>datos) {

			List<String> columnas = new List<string>();


			foreach (String colum in datos) {

				this.com.Parameters.AddWithValue("@DATO", colum);
				this.com.CommandType = System.Data.CommandType.StoredProcedure;
				this.com.CommandText = "MOSTRAR_DATOS";

				this.connect.Open();
				this.reader = this.com.ExecuteReader();

				while (this.reader.Read()) {

					columnas.Add(this.reader["COLUMNA"].ToString());
				}

				this.reader.Close();
				this.connect.Close();
				this.com.Parameters.Clear();
			}

			return columnas;
        }
    }
}
