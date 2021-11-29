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
                }
            }
        }
    }
}
