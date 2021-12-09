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

/*CREATE PROCEDURE BUSCADOR_PLANTILLA_SALARIO (@SALARIO INT)
AS
SELECT * FROM PLANTILLA WHERE SALARIO>=@SALARIO
GO*/
#endregion

namespace AdoNet
{
    public partial class form06BuscadorProcedure : Form
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;


        public form06BuscadorProcedure()
        {
            InitializeComponent();
            String cadenaconexion = "Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            
            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //LOS PARAMETROS SON ENVIADOS EN COMMAND

            int salario = int.Parse(this.txtSalario.Text);

            SqlParameter pmSal = new SqlParameter("@SALARIO",salario); //EL NOMBRE DEL PARÁMETRO DEBE SER EL MISMO AL PUESTO EN EL PROCEDURE
            this.com.Parameters.Add(pmSal);

            this.com.CommandType = CommandType.StoredProcedure; //Le decimos que vamos a llamar a un procedimiento almacenado
            this.com.CommandText = "BUSCADOR_PLANTILLA_SALARIO";

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            this.lstPlantilla.Items.Clear();

            while (this.reader.Read()) {

                string apellido = this.reader["APELLIDO"].ToString();
                string sal = this.reader["SALARIO"].ToString();

                this.lstPlantilla.Items.Add(apellido+" - "+sal);

            }

            this.reader.Close();
            this.connect.Close();
            this.com.Parameters.Clear();

        }
    }
}
