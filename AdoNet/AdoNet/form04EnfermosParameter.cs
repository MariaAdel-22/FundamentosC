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
    public partial class form04EnfermosParameter : Form
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public form04EnfermosParameter()
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

            String sql = "SELECT * FROM ENFERMO";

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                String apellido = this.reader["APELLIDO"].ToString();
                String inscripcion = this.reader["INSCRIPCION"].ToString();

                this.lstEnfermos.Items.Add(apellido+ " - "+inscripcion);
            }

            this.reader.Close();
            this.connect.Close();
        }
    }
}
