using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Formulario
{
    public partial class form23TrabajarFicheros : Form
    {
        public form23TrabajarFicheros()
        {
            InitializeComponent();
        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Este objeto es el browser de nuestras rutas (la que nos aparece por ejemplo para seleccionar un fichero)

            if (ofd.ShowDialog() == DialogResult.OK) {  //Lo que hace es que cuando seleccionamos un fichero nos devuelve su ruta

                String path = ofd.FileName;

                FileInfo file = new FileInfo(path); //Lo que nos hace, primero, es crear este fichero si no existe en dicha ruta, y si está creado nos permite generar el lector de su contenido

                //Vamos a leer un fichero, necesitamos abrir el archivo y asegurarnos que ha sido abierto y que sea accesible

                using (TextReader reader = file.OpenText()) { //Usando un bloque using lo que hacemos es asegurarnos de que lea el archivo cuando esté accesible (es asíncrono)

                    String contenido = await reader.ReadToEndAsync(); //Le decimos que lea el fichero hasta el final de manera asíncrono

                    reader.Close(); //Hay que cerrar el flujo de datos

                    this.txtContenido.Text = contenido; //Mostramos en el txtContenido todo lo que hemos obtenido en el string al leer el fichero
                    this.SetStringNombres(contenido); //Cuando cargue el fichero entonces nos muestre el contenido que tenemos guardado en el array
                }
            }
        }

        //Metodo para recuperar los nombres de la lista y separarlos con comas

        public String GetStringNombres() {

            String datos = "";

            foreach (String nombre in this.lstNombres.Items) { //Así recorremos todos los items del listbox

                datos += nombre + " , ";
            }

            datos = datos.Trim(','); //Quitamos la última coma

            return datos;
        }

        //Metodo para escribir los nombres en la lista

        public void SetStringNombres(String data) {

            String [] nombres = data.Split(','); //Creamos un array donde quitamos las comas y guardamos todos sus valores
            this.lstNombres.Items.Clear();

            foreach (String nombre in nombres) {

                this.lstNombres.Items.Add(nombre); //Ahora añadimos todos los valores que guardamos en el array nombres
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog(); //Es el objeto que debemos usar para preguntar si queremos guardar el fichero

            if (s.ShowDialog() == DialogResult.OK) {

                String path = s.FileName; //Recogemos la ruta del fichero donde queremos guardar
                FileInfo file = new FileInfo(path); //Creamos el archivo en la ruta especificada

                using (TextWriter writer = file.CreateText()) { //Lo que le estamos diciendo que este bloque asíncrono será de escritura (y el anterior era de lectura)

                    String contenido = this.GetStringNombres();

                    await writer.WriteAsync(contenido); //Le estamos diciendo que en el fichero ahora que guarde lo que nos devuelve el método Get

                    //Siempre que escribamos debemos liberar la memoria con Flush
                    await writer.FlushAsync();

                    //Cerramos el flujo de datos
                    writer.Close();

                }

                MessageBox.Show("Archivo guardado");
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String nombre = this.txtNombre.Text;//Recogemos el valor del texto nombre
            this.lstNombres.Items.Add(nombre);//Lo añadimos en el listado de listbox

            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }
    }
}
