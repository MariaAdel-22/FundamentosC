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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Primer Form App";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Propiedades más comunes: la propiedad de tipo primitivo (int,string,...)
            this.txt1.Width = 250;
            this.btn1.Text = "Pulsando...";

            //Tenemos propiedades de tipo objeto, en dichas propiedades debemos instanciar un objeto y adaptarnos a lo que nos pide
            this.btn1.Location = new Point(20,50);

            //Existen algunas clases (rara excepcion) que no se crean pero se utilizan, dichas clases están cerradas, es que no existe mas formas de crear su valor y nos lo ofrecen directamente
            this.btn1.BackColor = Color.Yellow;

            //Propiedades enumeradas: Una propiedad enumerada me ofrece el valor directamente de forma textual, internamente tiene un número int.

            this.txt1.TextAlign = HorizontalAlignment.Center;

            int numeroM = 999;
            short numeroMenor = 888;
            numeroMenor = (short)numeroM;

            String texto = "22";
            int numero = int.Parse(texto);

            int dato = 25;
            String valor = dato.ToString();
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
