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
    public partial class form19TablaMultiplicar : Form
    {

        List<TextBox> listado;

        public form19TablaMultiplicar()
        {
            InitializeComponent();

            this.listado = new List<TextBox>();

            foreach (Control ctrl in this.panelTabla.Controls) {

                if (ctrl is TextBox) {

                    this.listado.Add((TextBox)ctrl);
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            int cont = 0;
            foreach (TextBox tb in this.listado) {

                int numero = int.Parse(this.txtNumero.Text);
                cont++;

                tb.Text = (numero * cont).ToString();
            }
        }
    }
}
