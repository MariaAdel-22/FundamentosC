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
    public partial class form18SumarNumeros : Form
    {

        List<Button> botones;

        public form18SumarNumeros()
        {
            InitializeComponent();

            botones = new List<Button>();

            Random rand = new Random();


            foreach (Control btn in this.panelBotones.Controls) { //LO QUE HACEMOS ES RECORRER CADA BOTON DEL CONTENEDOR

                if (btn is Button)

                {
                    btn.Text = rand.Next(1, 50).ToString(); //CREAR LOS VALORES RANDOM
                    botones.Add((Button)btn);//lOA AÑADIMOS A LA COLECCION
                    btn.Click += SumarNumero;//CREAMOS SU FUNCIÓN
                }        
            }
        }

        private void SumarNumero(object sender, EventArgs e)
        {

            Button boton = (Button)sender;//EN UN OBJETO BOTÓN GUARDAMOS EL BOTÓN QUE HA SIDO PULSADO
            boton.BackColor = Color.LightGreen;

            int numero = int.Parse(boton.Text);
            int suma = int.Parse(this.txtNumero.Text);

            suma += numero;

            this.txtNumero.Text = suma.ToString();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            Random ram = new Random();

            foreach (Control botones in this.panelBotones.Controls) {

                if(botones is Button){

                    botones.Text = ram.Next(1, 50).ToString();
                    this.txtNumero.Text = "0";
                    botones.BackColor = Control.DefaultBackColor;//Así se pone el color por defecto 
                }
            }
        }
    }
}
