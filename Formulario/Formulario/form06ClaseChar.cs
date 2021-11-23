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
    public partial class form06ClaseChar : Form
    {
        public form06ClaseChar()
        {
            InitializeComponent();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            for (int i=0;i<=255;i++) {

                char caracter = (char)i; //Hacemos un casting para que recoja el valor de i

                if (char.IsLetter(caracter) == true) {

                    this.txtLetras.Text += caracter; //De esta forma se van (concatenando) añadiendo los valores en el input dependiendo de si es un tipo de valor u otro

                } else if (char.IsNumber(caracter) == true) {

                    this.txtNumeros.Text += caracter;

                } else if (char.IsSymbol(caracter) == true) {

                    this.txtSimbolos.Text += caracter;

                } else if (char.IsPunctuation(caracter) == true) {

                    this.txtPuntuacion.Text += caracter;
                }
            }
        }
    }
}
