using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class form17ColeccionList : Form
    {

        int contador;
        List<Button> botones;

        public form17ColeccionList()
        {
            InitializeComponent();

            this.contador = 0;
            this.botones = new List<Button>();

            foreach (Control ctrl in this.Controls) { //Lo que hacemos es recorrer todos los controles del formulario (en este caso botones)

                if (ctrl is Button) { //Le decimos si el objeto control es de tipo button

                    this.botones.Add((Button)ctrl);//Para poder almacenarlo RECUERDA que es de tipo BUTTON, hay que CASTEARLO
                }
            }

            foreach (Button btn in botones) {

                btn.BackColor = Color.LightBlue;
                btn.Click += IncrementarContador;
            }
        }

        private void IncrementarContador(object sender, EventArgs e)
        {

            this.contador += 1;
            string nombre = ((Button)sender).Name;

            this.lblContador.Text = nombre+": " + this.contador;

        }

        private void form17ColeccionList_Load(object sender, EventArgs e)
        {

        }
    }
}
