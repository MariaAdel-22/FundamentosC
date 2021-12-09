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


#region PROCEDIMIENTOS ALMACENADOS

/*
 ALTER PROCEDURE INSERTAR_DEPARTAMENTO (@NUMERO INT, @NOMBRE NVARCHAR(50),@LOCALIDAD NVARCHAR(50))
AS
	--NO QUEREMOS LOCALIDADES EN TERUEL--

	IF(@LOCALIDAD = 'TERUEL')

	BEGIN
		PRINT 'TERUEL NO EXISTE'
	END

	ELSE

	BEGIN
		INSERT INTO DEPT VALUES (@NUMERO,@NOMBRE,@LOCALIDAD)
	END
GO
*/
#endregion

namespace AdoNet
{
    public partial class form08MensajesServidor : Form
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;


        public form08MensajesServidor()
        {
            InitializeComponent();
            String cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            this.connect.InfoMessage += Connect_InfoMessage;

            this.CargarDepartamentos();
        }

        private void Connect_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensajes.Text = e.Message;
        }

        private void CargarDepartamentos() {

            string sql = "SELECT * FROM DEPT";

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                string dept = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();

                this.lstDepartamentos.Items.Add(dept+" - "+nombre+" - "+localidad);
            }

            this.reader.Close();
            this.connect.Close();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensajes.Text = "";

            SqlParameter pmNum = new SqlParameter("@NUMERO",int.Parse(this.txtNumero.Text));
            SqlParameter pmNom = new SqlParameter("@NOMBRE", this.txtNombre.Text);
            SqlParameter pmLoc = new SqlParameter("@LOCALIDAD", this.txtLocalidad.Text);

            this.com.Parameters.Add(pmNum);
            this.com.Parameters.Add(pmNom);
            this.com.Parameters.Add(pmLoc);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "INSERTAR_DEPARTAMENTO";

            this.lstDepartamentos.Items.Clear();

            this.connect.Open();
            int eliminado= this.com.ExecuteNonQuery();

            this.connect.Close();
            this.com.Parameters.Clear();

            this.CargarDepartamentos();
        }
    }
}
