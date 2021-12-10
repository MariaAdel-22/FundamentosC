using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

#region PROCEDIMIENTOS

/*
 CREATE VIEW EMPLEADOS_HOSPITAL 
AS
	SELECT PLANTILLA.APELLIDO AS APELLIDO, PLANTILLA.SALARIO AS SALARIO, PLANTILLA.HOSPITAL_COD AS 
    CODIGO FROM PLANTILLA INNER JOIN HOSPITAL ON PLANTILLA.HOSPITAL_COD=HOSPITAL.HOSPITAL_COD
	UNION
	SELECT DOCTOR.APELLIDO AS APELLIDO, DOCTOR.SALARIO AS SALARIO, DOCTOR.HOSPITAL_COD AS CODIGO FROM DOCTOR INNER JOIN HOSPITAL 
    ON DOCTOR.HOSPITAL_COD=HOSPITAL.HOSPITAL_COD
	
GO

CREATE PROCEDURE RECOGER_DATOS (@NOMBRE NVARCHAR(50), @SUMA INT OUT, @MEDIA INT OUT, @EMPLEADOS INT OUT)
AS
	DECLARE @HOSPITAL_COD INT;

	SELECT @HOSPITAL_COD= HOSPITAL_COD FROM HOSPITAL WHERE NOMBRE=@NOMBRE

	SELECT @SUMA= SUM(SALARIO), @MEDIA=AVG(SALARIO), @EMPLEADOS=COUNT(APELLIDO) FROM EMPLEADOS_HOSPITAL 
	WHERE CODIGO= @HOSPITAL_COD

	SELECT APELLIDO FROM EMPLEADOS_HOSPITAL WHERE CODIGO=@HOSPITAL_COD
	
GO
 */

#endregion

namespace AdoNet
{
    public partial class form11PlantillaDoctorHospital : Form
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public form11PlantillaDoctorHospital()
        {
            InitializeComponent();
            
            IConfigurationBuilder builder = new ConfigurationBuilder()
            .AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();
            String cadenaconexion = config["hospitalCasa"];
            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            this.CargarHospital();
        }


        private void CargarHospital() {

            string sql = "SELECT NOMBRE FROM HOSPITAL GROUP BY NOMBRE";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.connect.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }
            this.reader.Close();
            this.connect.Close();

        }


        private void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hosp = this.cmbHospitales.SelectedItem.ToString();

            this.com.Parameters.AddWithValue("@NOMBRE", hosp);

            SqlParameter pmSuma = new SqlParameter("@SUMA",0);
            SqlParameter pmMedia = new SqlParameter("@MEDIA",0);
            SqlParameter pmEmp = new SqlParameter("@EMPLEADOS", 0);

            pmSuma.Direction = ParameterDirection.Output;
            pmMedia.Direction = ParameterDirection.Output;
            pmEmp.Direction = ParameterDirection.Output;

            this.com.Parameters.Add(pmSuma);
            this.com.Parameters.Add(pmMedia);
            this.com.Parameters.Add(pmEmp);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "RECOGER_DATOS";

            this.cmbHospitales.Items.Clear();
            this.connect.Open();

            this.reader = this.com.ExecuteReader();

            this.lstEmpleados.Items.Clear();

            while (this.reader.Read()) {

                string apellidos = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellidos);
            }

            this.reader.Close();

            this.txtSuma.Text = pmSuma.Value.ToString();
            this.txtMedia.Text = pmMedia.Value.ToString();
            this.txtPersonas.Text = pmEmp.Value.ToString();

            this.connect.Close();
            this.com.Parameters.Clear();

            this.CargarHospital();
        }
    }
}
