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
    public partial class form03ColorPos : Form
    {
        public form03ColorPos()
        {
            InitializeComponent();
        }

        private void btnPosicion_Click(object sender, EventArgs e)
        {
            
            int X = int.Parse(this.txt1X.Text);
            int Y = int.Parse(this.txt2Y.Text);

            this.btnPosicion.Location = new Point(X,Y);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);

            this.BackColor = Color.FromArgb(rojo, verde, azul); //Con el this le estoy especificando con el formulario que estoy trabajando
        }
    }
}
