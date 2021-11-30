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

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            if (sfd.ShowDialog() == DialogResult.OK) {

                String path = sfd.FileName;
                await this.helper.SaveFileMascotas(path);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK) {

                String path = ofd.FileName;
                this.helper.ReadFileMascotas(path);
                this.DibujarMascotas();

            }
        }

        private void lsMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lsMascotas.SelectedIndex !=-1) {

                Mascota mascota = this.helper.Mascotas[this.lsMascotas.SelectedIndex]; //Aquí le estamos diciendo que en el listado se posicione en el índice que aparece en el listbox Ej: Mascotas[i]
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }
    }
}
