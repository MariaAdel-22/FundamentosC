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
    public partial class form05ModificarSalas : Form
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public form05ModificarSalas()
        {
            InitializeComponent();

            String cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";

            this.connect = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.com.Connection = this.connect;

            this.MostrarSalas();

        }

        private void MostrarSalas() {

            this.lstSalas.Items.Clear();

            String sql = "SELECT NOMBRE FROM SALA GROUP BY NOMBRE";

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read())
            {

                String nombre = this.reader["NOMBRE"].ToString();

                this.lstSalas.Items.Add(nombre);
            }

            this.reader.Close();
            this.connect.Close();

        }


        private void lstSalas_SelectedIndexChanged(object sender, EventArgs e)
        {
           int indice= this.lstSalas.SelectedIndex;

            this.txtNombre.Text = this.lstSalas.Items[indice].ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            String nombreNuevo = this.txtNombre.Text;
            String nombreAntiguo = this.lstSalas.Items[this.lstSalas.SelectedIndex].ToString();

            String sql = "UPDATE SALA SET NOMBRE=@NombreNuevo WHERE NOMBRE=@NombreAntiguo";

            SqlParameter param1 = new SqlParameter("@NombreNuevo",nombreNuevo);
            SqlParameter param2 = new SqlParameter("@NombreAntiguo",nombreAntiguo);

            this.com.Parameters.Add(param1);
            this.com.Parameters.Add(param2);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();

            int eliminado = this.com.ExecuteNonQuery();

            this.connect.Close();

            this.com.Parameters.Clear();
            this.MostrarSalas();
        }
    }
}
