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

namespace AdoNet
{
    public partial class form03EliminarEnfermos : Form
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public form03EliminarEnfermos()
        {

            InitializeComponent();

            string cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.connect = new SqlConnection(cadenaconexion);

            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            this.MostrarEnfermos();
        }

        private void MostrarEnfermos() {

            this.lstEnfermos.Items.Clear();

            string sql = "SELECT * FROM ENFERMO";

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                String apel = this.reader["APELLIDO"].ToString();
                String inscrip = this.reader["INSCRIPCION"].ToString();

                this.lstEnfermos.Items.Add(apel+" - "+inscrip);
            }

            this.reader.Close();
            this.connect.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String inscripcion = this.txtInscripcion.Text;
            String sql = "DELETE FROM ENFERMO WHERE INSCRIPCION=" + inscripcion;

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();

            //Las consultas de acción se ejecutan con ExecuteNonQuery() --> Devuelve un número con los registros afectados por la consulta
            
            int eliminados = this.com.ExecuteNonQuery();
            this.connect.Close();

            MessageBox.Show("Enfermos eliminados: " + eliminados);

            this.MostrarEnfermos();
        }
    }
}
