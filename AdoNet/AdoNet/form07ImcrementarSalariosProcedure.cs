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
 LTER PROCEDURE UPDATE_SALARIO_HOSPITAL (@NOMBRE NVARCHAR(50))
AS

DECLARE @HOSPITAL_COD INT
DECLARE @SUMA_SALARIAL INT

SELECT @HOSPITAL_COD=HOSPITAL_COD FROM HOSPITAL WHERE NOMBRE=@NOMBRE --RECOGEMOS AQUÍ EL CÓDIGO DEL HOSPITAL--
SELECT @SUMA_SALARIAL=SUM(SALARIO) FROM PLANTILLA WHERE HOSPITAL_COD=@HOSPITAL_COD --AQUÍ RECOGEMOS LA SUMA SALARIAL DEL CÓDIGO DEL HOSPITAL RECOGIDO EN LA VARIABLE

IF (@SUMA_SALARIAL > 1000000)
BEGIN 
	UPDATE PLANTILLA SET SALARIO=SALARIO - 10000
	PRINT 'BAJANDO SALARIOS'
END
ELSE

BEGIN
	UPDATE PLANTILLA SET SALARIO=SALARIO+10000 WHERE HOSPITAL_COD=@HOSPITAL_COD
	PRINT 'SUBIENDO SALARIOS'
END

SELECT * FROM PLANTILLA WHERE HOSPITAL_COD=@HOSPITAL_COD
GO

EXEC UPDATE_SALARIO_HOSPITAL 'la paz'
 */

#endregion

namespace AdoNet
{
    public partial class form07ImcrementarSalariosProcedure : Form
    {

        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public form07ImcrementarSalariosProcedure()
        {
            InitializeComponent();
            String cadenaconexion = "Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            
            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            string sql = "SELECT * FROM HOSPITAL";

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);

            }

            this.reader.Close();
            this.connect.Close();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString(); //Recogemos el nombre del elemento seleccionado

            SqlParameter paramNombre = new SqlParameter("@NOMBRE",nombre);
            this.com.Parameters.Add(paramNombre);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "UPDATE_SALARIO_HOSPITAL";

            this.connect.Open();
            this.reader = this.com.ExecuteReader(); //El executeReader nos hará tanto el select como el insert

            this.lstPlantilla.Items.Clear();

            while (this.reader.Read()) {

                string apellido = this.reader["APELLIDO"].ToString();
                string funcion = this.reader["FUNCION"].ToString();
                string salario = this.reader["SALARIO"].ToString();

                this.lstPlantilla.Items.Add(apellido+", "+funcion+", "+salario);
            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();
        }
    }
}
