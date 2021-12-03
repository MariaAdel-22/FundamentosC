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
    public partial class form02BuscadorEmpleado : Form
    {
        SqlConnection connect;
        SqlCommand com;
        SqlDataReader reader;

        public form02BuscadorEmpleado()
        {
            InitializeComponent();

            String cadenaconexion = @"Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.connect = new SqlConnection();
            this.com = new SqlCommand();

            //También vamos a indicar la conexión que utilizará nuestro comando

            this.connect.ConnectionString = cadenaconexion;
            this.com.Connection = this.connect;

        }

        private void btnSalario_Click(object sender, EventArgs e)
        {
            String datosalario = this.txtSalario.Text;
            String sql = "SELECT * FROM EMP WHERE SALARIO >" + datosalario;

            this.lstEmpleados.Items.Clear();

            //Tipo de consulta
            this.com.CommandType = CommandType.Text;

            //Consulta SQL

            this.com.CommandText = sql;

            //SIEMPRE SERÁ ENTRAR/SALIR

            //ABRIR CONEXION
            this.connect.Open();

            //EJECUTAR CONSULTA

            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                String apellido = this.reader["APELLIDO"].ToString();
                String sal = this.reader["SALARIO"].ToString();

                this.lstEmpleados.Items.Add(apellido+" - "+sal);
            }

            //SALIMOS cerrando tanto el reader como la conexión

            this.reader.Close();
            this.connect.Close();

        }

        private void btnOficio_Click(object sender, EventArgs e)
        {
            String oficio = this.txtOficio.Text;

            String sql = "SELECT * FROM EMP WHERE OFICIO='" + oficio+"'";

            this.lstEmpleados.Items.Clear();

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();
            this.reader = this.com.ExecuteReader();

            while (this.reader.Read()) {

                String apellido = this.reader["APELLIDO"].ToString();
                String ofi = this.reader["OFICIO"].ToString();

                this.lstEmpleados.Items.Add(apellido+ " - "+ofi);

            }

            this.reader.Close();
            this.connect.Close();
        }
    }
}
