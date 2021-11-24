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

            for (int i=0;i<longitud;i++) {

                char caracter = cadena[i]; //En una variable de tipo char nos guardamos cada número de la cadena al recorrer el for
                int numero = int.Parse(caracter.ToString()); //Recogemos cada valor de manera literal (pasando a string)
                int multi = numero * (i + 1); //Luego lo que hacemos es multiplicar dicho número por i+1 (empieza por 1)
                multiplicacion += multi; //Vamos recogiendo cada resultado de la multiplicación y la sumamos

            }

            if (multiplicacion % 11 == 0)
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
