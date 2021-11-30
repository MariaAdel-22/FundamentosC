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
using ProyectoClases;

namespace Formulario
{
    public partial class form25FicherosMascotas : Form
    {
        HelperMascotas helper;

        public form25FicherosMascotas()
        {
            InitializeComponent();
            this.helper = new HelperMascotas();
        }

        private void DibujarMascotas() {

            this.lsMascotas.Items.Clear();

            foreach (Mascota mascota in this.helper.Mascotas) {

                this.lsMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();

            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;

            this.helper.Mascotas.Add(mascota);

            this.DibujarMascotas();
        }
    }
}
