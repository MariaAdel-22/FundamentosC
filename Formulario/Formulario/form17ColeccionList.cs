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

            botones.Add(this.button1);
            botones.Add(this.button2);
            botones.Add(this.button3);

            foreach (Button btn in botones) {

                btn.BackColor = Color.LightBlue;
                btn.Click += IncrementarContador;
            }
        }

        private void IncrementarContador(object sender, EventArgs e)
        {

            this.contador += 1;
            this.lblContador.Text = "Contador: " + this.contador;

        }
    }
}
