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
            int rojo = int.Parse(this.txtRojo.Text) <= 255 && int.Parse(this.txtRojo.Text) > 0 ? int.Parse(this.txtRojo.Text) : 255; 
            //Es un if que comprueba si el valor pasado es mayor que 255 y si el valor es mayor a 0 entonces el valor de rojo será 255 (pasar por false), pero si es menor a 255 entonces coge ese valor (true)
            int verde = int.Parse(this.txtVerde.Text) <= 255 && int.Parse(this.txtVerde.Text) > 0 ? int.Parse(this.txtVerde.Text) : 255;
            int azul = int.Parse(this.txtAzul.Text) <= 255 && int.Parse(this.txtAzul.Text) > 0 ? int.Parse(this.txtAzul.Text) : 255;

            this.BackColor = Color.FromArgb(rojo, verde, azul); //Con el this le estoy especificando con el formulario que estoy trabajando
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNum.Text);

            if (num > 0)
            {

                this.lblResultado.Text = "POSITIVO";
                this.lblResultado.ForeColor = Color.Green; //ForeColor es para cambiar el color de la letra
            }
            else if (num == 0)
            {

                this.lblResultado.Text = "ES CERO";
                this.lblResultado.ForeColor = Color.Blue;
            }
            else {

                this.lblResultado.Text = "NEGATIVO";
                this.lblResultado.ForeColor = Color.Red;
            }
        }
    }
}
