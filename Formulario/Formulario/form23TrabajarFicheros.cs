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
using ProyectoClases.Helpers;

namespace Formulario
{
    public partial class form23TrabajarFicheros : Form
    {
        HelperFileNombres helper;

        public form23TrabajarFicheros()
        {
            InitializeComponent();
            this.helper = new HelperFileNombres();

        }

        private async void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Este objeto es el browser de nuestras rutas (la que nos aparece por ejemplo para seleccionar un fichero)

            if (ofd.ShowDialog() == DialogResult.OK) {  //Lo que hace es que cuando seleccionamos un fichero nos devuelve su ruta

                String path = ofd.FileName;


                List<String> nombres=await helper.ReadFileNombres(path); //RECUERDA todos los métodos asíncronos se llaman con await
                this.lstNombres.Items.Clear();

                foreach (String nombre in nombres) {

                    this.lstNombres.Items.Add(nombre);
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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog s = new SaveFileDialog(); //Es el objeto que debemos usar para preguntar si queremos guardar el fichero

            if (s.ShowDialog() == DialogResult.OK) {

                String path = s.FileName; //Recogemos la ruta del fichero donde queremos guardar
                FileInfo file = new FileInfo(path); //Creamos el archivo en la ruta especificada

                String contenido = this.GetStringNombres();
                await helper.WriteFileNombres(path,contenido);

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
