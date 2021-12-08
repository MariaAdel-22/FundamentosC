using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosExtra.Consultas;

namespace EjerciciosExtra
{
    public partial class Form1 : Form
    {
        String path;
        int cod_coche;
        CochesConsultas_BBDD consult;

        public Form1()
        {
            InitializeComponent();
            this.cod_coche = 0;
            this.consult = new CochesConsultas_BBDD();
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == DialogResult.OK) {

                this.path = opf.FileName;
                this.pctImagen.Image = Image.FromFile(this.path);
            }
        }

        private byte[] ConvertirImagen(System.Drawing.Image imag) {

            using (var ms= new MemoryStream()) {

                imag.Save(ms, imag.RawFormat);

                return ms.ToArray();
            }

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            this.cod_coche += 1;

            Coche coche = new Coche();

            coche.Marca = this.txtMarca.Text;
            coche.Modelo = this.txtModelo.Text;

            coche.Color = this.txtColor.Text;
            coche.fechaInscripcion = DateTime.Parse(this.txtFecha.Text);

            byte[] imagen = this.ConvertirImagen(this.pctImagen.Image);
            coche.Imagen = imagen;

            coche.Cod_Coche = this.cod_coche;

            this.consult.InsertarCoche(coche);
            this.lstCoches.Items.Add(coche.Modelo);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            this.gpOpciones.Enabled = true;

            List<String> resultado;

            if (this.rdColor.Checked) {

                resultado = new List<string>();

                resultado=this.consult.MostrarCoches(color:true);

                foreach (String filas in resultado) {

                    this.lstCoches.Items.Add(filas);
                }
            }

            if (this.rdMarca.Checked) {

                resultado = new List<string>();

                resultado = this.consult.MostrarCoches(marca: true);

                foreach (String filas in resultado) {

                    this.lstCoches.Items.Add(filas);
                }
            }

            //FALTA LOS RADIOBUTTON DE MODELO Y FECHA, HACER MODIFICAR Y ELIMINAR
        }

    }
}
