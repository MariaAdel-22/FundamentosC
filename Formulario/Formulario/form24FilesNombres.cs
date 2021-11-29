using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases.Helpers;

namespace Formulario
{
    public partial class form24FilesNombres : Form
    {
        HelperFileNombresOK helper;

        public form24FilesNombres()
        {
            InitializeComponent();
        }

        private void DibujarNombres() { //Este método será con el que dibujemos los nombres en el listbox 

            this.lstNombres.Items.Clear();

            foreach (String nombre in this.helper.Nombres) { //Vamos leyendo todos los nombres guardados en la colección nombre que tiene la clase de helper como propiedad

                this.lstNombres.Items.Add(nombre); 
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            String name = this.txtNombre.Text;
            this.helper.Nombres.Add(name);
            this.DibujarNombres();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK) {

                String path = ofd.FileName;

                this.helper = new HelperFileNombresOK(path);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           this.helper.WriteFile();
            MessageBox.Show("Datos guardados");
        }
    }
}
