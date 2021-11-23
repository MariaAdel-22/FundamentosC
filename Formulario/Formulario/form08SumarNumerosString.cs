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
    public partial class form08SumarNumerosString : Form
    {
        public form08SumarNumerosString()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            bool isNumber=true;
            string textoNumeros = this.txtNumeros.Text;

            for (int i=0;i<textoNumeros.Length;i++) {

                if (char.IsDigit(textoNumeros[i]) == false)
                { //Si no es un número lo que hay en la caja entonces haz...

                    isNumber = false;
                    break; //Le decimos que rompa el bucle si no es un número

                }
               
            }

            if (isNumber == false)
            {

                MessageBox.Show("Debe escribir números en la caja", "Warning"); //Para mostrar como un pop-up
                this.txtNumeros.SelectAll(); //Decimos que seleccione todo lo que tiene en su caja
                this.txtNumeros.Focus();
            }
            else {

                int suma = 0;

                for (int i=0;i<textoNumeros.Length;i++) {

                    char caracter = textoNumeros[i]; //Estamos recogiendo cada numero del texto

                    //La clase convert, sirve para conversiones especiales.int numero = Convert.ToInt32(caracter);


                    int numero = int.Parse(caracter.ToString());//Vamos parseando a tipo int cada numero recogido. ES IMPORTANTE pasar el tipo char a string, así se puede convertir el string a int sin problema
                    suma += numero;//Vamos sumando cada número que vamos leyendo de la caja al parsearlo
                }

                this.lblResultado.Text = "La suma es: " + suma;
            }
        }
    }
}
