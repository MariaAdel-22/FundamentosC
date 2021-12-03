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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String inscripcion = this.txtInscripcion.Text;

            String sql = "DELETE FROM ENFERMO WHERE INSCRIPCION=@INSCRIPCION";

            SqlParameter paramInscripcion = new SqlParameter(); //como @INSCRIPCION es decirle que le pasamos el valor por parámetro, debemos crear un objeto de tipo SqlParameter

            paramInscripcion.ParameterName = "@INSCRIPCION"; //El nombre de dicho parámetro debe coincidir con el escrito arriba
            paramInscripcion.Value = inscripcion;//El valor del parámetro va a ser el recogido en la variable inscripcion

            //UNA FORMA MÁS CORTA DE HACERLO: SqlParameter paramInscripcion= new SqlParameter("@INSCRIPCION",inscripcion)

            this.com.Parameters.Add(paramInscripcion);//Tenemos que añadir este nuevo parámetro a la colección de parámetros del objeto command

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.connect.Open();

            int eliminados = this.com.ExecuteNonQuery();

            this.connect.Close();

            //Hay que limpiar los parámetros porque cada vez que le pulsemos al botón de eliminar creará el parámetro @INSCRIPCION y no sabe cual de todos los creados hay que coger

            this.MostrarEnfermos();
            this.com.Parameters.Clear();
        }
    }
}
