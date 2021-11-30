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

namespace Formulario
{
    public partial class form27SerializationList : Form
    {
        XmlSerializer xmlserial;
        MascotasCollection mascotas;

        public form27SerializationList()
        {
            InitializeComponent();

            xmlserial = new XmlSerializer(typeof(MascotasCollection));
            mascotas = new MascotasCollection();

        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();

            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);

            this.mascotas.Add(mascota);

            this.DibujarMascotas();
        }

        private void DibujarMascotas() {

            this.lsMascotas.Items.Clear();

            foreach (Mascota mascota in this.mascotas) {

                this.lsMascotas.Items.Add(mascota.Nombre);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("listamascotas.xml");

            this.xmlserial.Serialize(writer,this.mascotas);

            await writer.FlushAsync();
            writer.Close();

            this.lsMascotas.Items.Clear();
            this.mascotas.Clear();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("listamascotas.xml");

            this.mascotas= (MascotasCollection) this.xmlserial.Deserialize(reader);

            reader.Close();

            this.DibujarMascotas();
        }
    }
}
