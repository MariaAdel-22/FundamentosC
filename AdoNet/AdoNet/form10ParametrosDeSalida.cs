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
 CREATE PROCEDURE EMPLEADOS_DEPT_OUTPUT (@DNOMBRE NVARCHAR(50),@SUMA INT OUT, @MEDIA INT OUT, @PERSONAS INT OUT)
AS
	DECLARE @DEPTNO INT
	
	SELECT @DEPTNO=DEPT_NO FROM DEPT WHERE DNOMBRE=@DNOMBRE
	
	--CONSULTA PARA LOS PARAMETROS DE SALIDA--
	
	SELECT @SUMA=SUM(SALARIO), @MEDIA=AVG(SALARIO), @PERSONAS=COUNT(EMP_NO) FROM EMP WHERE DEPT_NO=@DEPTNO
	
	--CONSULTA PARA DEVOLVER LOS EMPLEADOS(CURSOR)--
	
	SELECT * FROM EMP WHERE DEPT_NO=@DEPTNO
	
GO

 */
#endregion

namespace AdoNet
{
    public partial class form10ParametrosDeSalida : Form
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public form10ParametrosDeSalida()
        {
            InitializeComponent();

            IConfigurationBuilder builder = new ConfigurationBuilder().AddJsonFile("config.json");
            IConfigurationRoot config = builder.Build();

            String cadenaconexion = config["CadenaHospital"];

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            string sql = "SELECT * FROM DEPT";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                string nombre = this.reader["DNOMBRE"].ToString();
                this.cmbDepartamentos.Items.Add(nombre);
            }

            this.reader.Close();
            this.connect.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String nombre = this.cmbDepartamentos.SelectedItem.ToString();

            //NO ES NECESARIO CREAR PARAMETROS PARA LOS DE ENTRADA

            this.com.Parameters.AddWithValue("@NOMBRE", nombre);

            SqlParameter pamSuma = new SqlParameter("@SUMA",0);
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);

            SqlParameter pamMedia = new SqlParameter("@MEDIA",0);
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);

            SqlParameter pamPersonas = new SqlParameter("@PERSONAS",0);
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "EMPLEADOS_DEPT_OUTPUT";
            this.connect.Open();

            this.reader = this.com.ExecuteReader();

            this.lstEmpleados.Items.Clear();

            while (this.reader.Read()) {

                string apellido = this.reader["APELLIDO"].ToString();
                this.lstEmpleados.Items.Add(apellido);

            }

            //HASTA QUE EL READER NO SE HA CERRADO NO TENDREMOS EL VALOR DE LOS PARAMETROS
        
            this.reader.Close();

            this.lblMedia.Text = "Media: " + pamMedia.Value;
            this.lblSuma.Text = "Suma: " + pamSuma.Value;
            this.lblPersonas.Text = "Personas: " + pamPersonas.Value;

            this.connect.Close();
            this.com.Parameters.Clear();


        }
    }
}
