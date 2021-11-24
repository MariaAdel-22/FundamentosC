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
    public partial class form13ColeccionNumeros : Form
    {
        public form13ColeccionNumeros()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random numerosRandom = new Random();
           

            this.lsNumeros.Items.Clear();

            for (int i=0;i<=10;i++) {

                int valor = numerosRandom.Next(1, 50); //Estamos generando numeros random de 1 a 50
                this.lsNumeros.Items.Add(valor);
            }
 
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumar=0, pares=0, impares=0;

            foreach (Object obj in this.lsNumeros.Items) {

                int num = (int)obj; /*Vamos recogiendo el objeto convertido a tipo int en una variable número para después recogerlo
                 y usarlo en el segundo foreach*/
            }

            foreach (int num in this.lsNumeros.Items){

                sumar += num;

                if (num % 2 == 0)
                {

                    pares += num;

                }
                else {

                    impares += num;
                }
            }

            this.txtSuma.Text = sumar.ToString();
            this.txtPares.Text = pares.ToString();
            this.txtImpares.Text = impares.ToString();
        }
    }
}
