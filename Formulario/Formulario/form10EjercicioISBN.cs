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
    public partial class form10EjercicioISBN : Form
    {
        public form10EjercicioISBN()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {

            int multiplicacion = 0;
            string cadena = this.txtISBN.Text;
            int longitud = cadena.Length;

            for (int i=0;i<=longitud-1;i++) {

                //int valor = cadena[i];
                char valor = cadena[i];
                multiplicacion =+ int.Parse(valor.ToString()) * i;
            }

            int validacion = multiplicacion / 11;

            if (validacion == 0)
            {

                this.lblResultado.Text = "ISBN es CORRECTO";
                this.lblResultado.ForeColor = Color.Blue;
            }
            else {

                this.lblResultado.Text = "ISBN es INCORRECTO";
                this.lblResultado.ForeColor = Color.Red;
            }
        }
    }
}
