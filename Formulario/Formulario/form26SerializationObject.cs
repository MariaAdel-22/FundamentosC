using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;
using System.Xml.Serialization;
using System.IO;

namespace Formulario
{
    public partial class form26SerializationObject : Form
    {
        XmlSerializer xmlserial;

        public form26SerializationObject()
        {
            InitializeComponent();

            this.xmlserial = new XmlSerializer(typeof(Mascota)); //Le estamos diciendo al objeto serializable que almacene el tipo Mascota (Object)
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {

            Mascota mascota = new Mascota();

            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);

            //Para serializar(escribir) se utiliza el objeto de Sytem.IO el StreamWriter. NO IMPORTA LA EXTENSION DEL ARCHIVO AL GUARDARLO PORQUE SIEMPRE TENDRÁ FORMATO XML INTERNAMENTE

            StreamWriter writer = new StreamWriter("mascota.xml");

            //Con el método serialize almacenamos el objeto y XML se encarga de darle forma String

            this.xmlserial.Serialize(writer,mascota); //Almacena el objeto serializable writer y el objeto que queremos almacenar (que en este caso es mascota)

            await writer.FlushAsync();
            writer.Close();

            this.txtEdad.Text = "";
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("mascota.xml");

            //La deserialización nos devuelve directamente el objeto mediante el método deserialize

            Mascota mascota = (Mascota)this.xmlserial.Deserialize(reader);

            reader.Close();

            this.txtNombre.Text = mascota.Nombre;
            this.txtRaza.Text = mascota.Raza;
            this.txtEdad.Text = mascota.Edad.ToString();

        }
    }
}
