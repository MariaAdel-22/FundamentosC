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
    public partial class Form1 : Form
    {
        String cadenaConexion; //La cadena para hacer la conexión a la BBDD

        SqlConnection conect; //Objeto de conexión
        SqlCommand com;//Objeto para hacer el comando
        SqlDataReader reader;//Objeto para leer el resultado del comando

        public Form1()
        {
            InitializeComponent();

            this.cadenaConexion = "Data Source=T06W05;Initial Catalog=hospital;Persist Security Info=True;User ID=SA;Password=MCSD2021";
            this.conect = new SqlConnection();
            this.com = new SqlCommand();

            this.conect.StateChange += Conect_StateChange; //Con este método lo que hacemos es ver el estado de la conexión cuando esté encendida o apagada o haya algo

            this.conect.ConnectionString = this.cadenaConexion; //Creamos la conexión a nuestra base de datos SIEMPRE en el constructor

            //El obj reader no se puede inicializar porque solo hay uno en cada comando
        }

        private void Conect_StateChange(object sender, StateChangeEventArgs e)
        {
            //OriginalState: Estado de la conexión inicial a cuando se enciende el servidor
            //CurrentState: Estado de la conexión actual

            //this.lblMensaje.Text = "Connection cambiando de " + e.OriginalState + " a " + e.CurrentState;

            this.lblMensaje.Text = e.CurrentState.ToString();

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

            if (this.conect.State == ConnectionState.Closed)
            { //Preguntamos si el estado de la conexión está cerrada

                this.conect.Open(); //Abrimos la conexión para poder empezar a realizar comandos
            }
            
            this.lblMensaje.BackColor = Color.LightGreen;
        }


        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.conect.Close();//Cerramos la conexión
            this.lblMensaje.BackColor = Color.LightCoral;
        }


        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Declaramos nuestra consulta SQL

            String sql = "SELECT * FROM EMP";

            //Indicamos al comando su conexion

            this.com.Connection = this.conect;

            //Indicamos el tipo de consulta (tipo TEXT al tener la consulta escrita en el código o tipo procedure si cogemos la consulta en la bbdd)

            this.com.CommandType = CommandType.Text;

            //Indicamos la consulta

            this.com.CommandText = sql;

            //DEBEMOS TENER LA CONEXIÓN ABIERTA PARA LOS SIGUIENTES PASOS

            //Ejecutamos la consulta y como es una consulta select devuelve un cursos (el DataReader)

            this.reader = this.com.ExecuteReader();

            //Vamos a dibujar la primera columna de la consulta y su tipo de dato

            for (int i=0;i<this.reader.FieldCount;i++) {

                String columna = this.reader.GetName(i); //Estamos recogiendo la primera columna de la tabla EMP (EMP_NO);
                String tipo = this.reader.GetDataTypeName(i); //El tipo de dato de dicha columna

                this.lstColumnas.Items.Add(columna);
                this.lstTiposDato.Items.Add(tipo);
            }


            //Vamos a recuperar un apellido. Para poder recuperar registros debemos leer, el cursor está posicionado por defecto en la fila -1, cada vez que leemos avanza 1 fila

            //this.reader.Read(); HAY QUE EMPEZAR A LEER, Y CON CADA READ() QUE HAGAMOS PASARÁ A LA SIGUIENTE FILA. (Es conveniente saberlo para un for)

            while (this.reader.Read()) {

                String apellido = this.reader["APELLIDO"].ToString();

                this.lsApellidos.Items.Add(apellido);

            }
            
            this.reader.Close();//ES IMPORTANTE CERRAR EL OBJETO READER PORQUE SI LE PULSAS AL BOTÓN MÁS DE UNA VEZ TE SALTA UNA EXCEPCIÓN DE QUE YA TIENES UN DATAREADER ABIERTO

        }

  
    }
}
