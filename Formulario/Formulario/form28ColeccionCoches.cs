using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using ProyectoClases;
using ProyectoClases.Helpers;

namespace Formulario
{
    public partial class form28ColeccionCoches : Form
    {

        ColeccionCoches coches;
        HelperCoches helper;
        String path;

        public form28ColeccionCoches()
        {
            InitializeComponent();
            coches = new ColeccionCoches();
            helper = new HelperCoches();
        }


        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofl = new OpenFileDialog();

            if (ofl.ShowDialog() == DialogResult.OK)
            {

                this.path = ofl.FileName;

                this.pctImagen.Image = Image.FromFile(this.path);
            }

        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche();

            coche.Marca = this.txtMarca.Text;
            coche.Modelo = this.txtModelo.Text;

            byte[] imagen = this.ImageToByteArray(this.pctImagen.Image);

            coche.Imagen = imagen;

            this.coches.Add(coche);

            this.lstCoches.Items.Add(coche.Marca);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            await this.helper.GuardarCoches(this.coches);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            this.coches.Clear();
            this.coches = (ColeccionCoches)this.helper.LeerCoches();

            foreach (Coche coche in this.coches) {

                this.lstCoches.Items.Add(coche.Marca);
            }
        }

        private void lstCoches_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = this.lstCoches.SelectedIndex;

            Coche coche = new Coche();

            coche=this.coches[indice];

            this.txtMarca.Text = coche.Marca;
            this.txtModelo.Text = coche.Modelo;

            using (var ms = new MemoryStream(coche.Imagen))
            {
                this.pctImagen.Image = Image.FromStream(ms);
            }
        }
    }
}
