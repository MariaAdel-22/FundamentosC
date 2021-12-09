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
 ALTER PROCEDURE INSERTAR_MODIFICAR_DOCTOR (@HOSPITAL_COD NVARCHAR(50), @DOCTOR_NO NVARCHAR(50),@APELLIDO NVARCHAR(50), @ESPECIALIDAD NVARCHAR(50),@SALARIO INT)
AS

DECLARE @ID_DOCTOR NVARCHAR(50)

	SELECT @ID_DOCTOR=DOCTOR_NO FROM DOCTOR WHERE DOCTOR_NO=@DOCTOR_NO

	IF(@ID_DOCTOR IS NULL)
	BEGIN
		INSERT INTO DOCTOR VALUES (@HOSPITAL_COD,@DOCTOR_NO,@APELLIDO,@ESPECIALIDAD,@SALARIO)
		PRINT 'SE HA INSERTADO EL DOCTOR'
	END
	ELSE

	BEGIN
		UPDATE DOCTOR SET HOSPITAL_COD=@HOSPITAL_COD, DOCTOR_NO=@DOCTOR_NO,APELLIDO=@APELLIDO,ESPECIALIDAD=@ESPECIALIDAD, SALARIO=@SALARIO WHERE DOCTOR_NO=@ID_DOCTOR
		PRINT 'SE HA ACTUALIZADO EL DOCTOR'
	END

GO
 */
#endregion

namespace AdoNet
{
    public partial class form09UpdateInsertDoctor : Form
    {
		SqlConnection connect;
		SqlCommand com;
		SqlDataReader reader;

        public form09UpdateInsertDoctor()
        {
            InitializeComponent();

			String cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";

			this.connect = new SqlConnection(cadenaconexion);
			this.com = new SqlCommand();
			this.com.Connection = this.connect;

            this.connect.InfoMessage += Connect_InfoMessage;
		}

        private void Connect_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
			this.lblMensaje.Text = e.Message;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

			this.lblMensaje.Text = "";

			SqlParameter pamHosp = new SqlParameter("@HOSPITAL_COD",this.txtHospCod.Text);
			SqlParameter pamDoc = new SqlParameter("@DOCTOR_NO",this.txtNumDoc.Text);
			SqlParameter pamApel = new SqlParameter("@APELLIDO",this.txtApellido.Text);

			SqlParameter pamEsp = new SqlParameter("@ESPECIALIDAD", this.txtEspecialidad.Text);
			SqlParameter pamSal = new SqlParameter("@SALARIO",int.Parse(this.txtSalario.Text));

			this.com.Parameters.Add(pamHosp);
			this.com.Parameters.Add(pamDoc);
			this.com.Parameters.Add(pamApel);

			this.com.Parameters.Add(pamEsp);
			this.com.Parameters.Add(pamSal);

			this.com.CommandType = CommandType.StoredProcedure;
			this.com.CommandText = "INSERTAR_MODIFICAR_DOCTOR";

			this.connect.Open();
			this.com.ExecuteNonQuery();

			this.connect.Close();
			this.com.Parameters.Clear();
		}
    }
}
