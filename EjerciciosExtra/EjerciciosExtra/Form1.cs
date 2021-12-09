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

            this.CargarCoches();
        }

        //Método privado para cargar los coches al inicializar el formulario
        private void CargarCoches() {

            this.lstCoches.Items.Clear();

            List<String> coches = this.consult.CargarCoches();

            foreach (String coche in coches) {

                this.lstCoches.Items.Add(coche);
            }
        }

        //Método para recoger la ruta de la imagen usando el objeto OpenFileDialog

        private void btnImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();

            if (opf.ShowDialog() == DialogResult.OK) {

                this.path = opf.FileName;
                this.pctImagen.Image = Image.FromFile(this.path);
            }
        }

        //Tenemos que convertir la imagen a un tipo de array de bytes para poder trabajar con ella (y subirla a la BBDD)
        private byte[] ConvertirImagen(System.Drawing.Image imag) {

            using (var ms= new MemoryStream()) {

                imag.Save(ms, imag.RawFormat);

                return ms.ToArray();
            }

        }

        //En éste método creamos un obj coche y se lo pasamos a la clase CochesConsultas_BBDD ya que ahí lo inserta en la BBDD

        private void btnCrear_Click(object sender, EventArgs e)
        {
  
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
            this.cod_coche += 1;
        }

        /*Para mostrar las diferentes búsquedas lo que hago es controlar qué radiobutton ha sido seleccionado (y al método que llamo solo
         * tiene parámetros de entrada opcionales, dependiendo de cual ha sido seleccionado le paso un parámetro u otro)
         */
        private void btnMostrar_Click(object sender, EventArgs e)
        {

            this.gpOpciones.Enabled = true;

            List<String> resultado;

            if (this.rdColor.Checked) {

                this.lstCoches.Items.Clear();
                resultado = new List<string>();

                resultado=this.consult.MostrarCoches(color:true);

                foreach (String filas in resultado) {

                    this.lstCoches.Items.Add(filas);
                }
            }

            if (this.rdMarca.Checked) {

                this.lstCoches.Items.Clear();
                resultado = new List<string>();

                resultado = this.consult.MostrarCoches(marca: true);

                foreach (String filas in resultado) {

                    this.lstCoches.Items.Add(filas);
                }
            }

            if (this.rdModelo.Checked) {

                this.lstCoches.Items.Clear();
                resultado = new List<string>();

                resultado = this.consult.MostrarCoches(modelo:true);

                foreach (String filas in resultado) {

                    this.lstCoches.Items.Add(filas);
                }
            }

            if (this.rdFecha.Checked) {

                this.lstCoches.Items.Clear();
                resultado = new List<string>();

                resultado = this.consult.MostrarCoches(fecha: true);

                foreach (String filas in resultado) {

                    this.lstCoches.Items.Add(filas);
                }
            }

        }

        //En este método creamos un obj coche y le pasamos dicho objeto al método de la clase que gestiona las consultas a la BBDD
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Coche coche = new Coche();

            coche.Cod_Coche = this.lstCoches.SelectedIndex;
            coche.Marca = this.txtMarca.Text;
            coche.Modelo = this.txtModelo.Text;

            coche.Color = this.txtColor.Text;
            byte[] imagen = this.ConvertirImagen(this.pctImagen.Image);
            coche.Imagen = imagen;

            coche.fechaInscripcion = DateTime.Parse(this.txtFecha.Text);

            this.consult.ModificarCoche(coche);

            this.CargarCoches();
        }

        //En éste método cargamos en los textBox y pictureBbox las propiedades recogidas en el obj Coche ya que el método devuelve un obj

        private void lstCoches_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cod_coche = this.lstCoches.SelectedIndex;

            Coche coche = new Coche();

            coche = this.consult.CargarCoche(cod_coche);

            this.txtMarca.Text = coche.Marca;
            this.txtModelo.Text = coche.Modelo;
            this.txtColor.Text = coche.Color;

            var ms = new MemoryStream(coche.Imagen);

            this.pctImagen.Image = Image.FromStream(ms);
            

            this.txtFecha.Text = coche.fechaInscripcion.ToString();
        }

        //En éste método le paso la posición que se encuentra en la lista el elemento y lo elimina en la clase de consultas de BBDD

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int cod_coche = this.lstCoches.SelectedIndex;

            this.consult.EliminarCoche(cod_coche);

            this.CargarCoches();
        }
    }
}
