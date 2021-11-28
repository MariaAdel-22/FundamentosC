using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoClases;

namespace Formulario
{

   
    public partial class form22EjemploMeses : Form
    {
        List<Mes> meses;

        public form22EjemploMeses()
        {
            InitializeComponent();
            this.meses = new List<Mes>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            DateTime fecha = DateTime.Parse("01/01/2021");
            Random rand = new Random();
            Mes objMes;

            for (int i = 1; i <= 12; i++)
            {

                int maxima = rand.Next(1, 60);
                int minima = rand.Next(1, 70);


                string nombreMes = fecha.ToString("MMMM").ToUpper();

                objMes = new Mes(nombreMes, maxima, minima);

                this.meses.Add(objMes);
               fecha= fecha.AddMonths(1);
            }

            foreach (Mes me in this.meses) {

                this.lsMeses.Items.Add(me._Nombre);
            }
        }

        private void lsMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            foreach (Mes me in this.meses) {

                if (me._Nombre == this.lsMeses.SelectedItem.ToString()) {

                    this.txtMes.Text = this.lsMeses.SelectedItem.ToString();
                    this.txtMaxima.Text = me._temperaturaMaxima.ToString();
                    this.txtMinima.Text = me._temperaturaMinima.ToString();
                    this.txtMedia.Text = me.CalcularTemperaturaMedia(me._temperaturaMaxima,me._temperaturaMinima).ToString();
                }
            }
        }
    }
}
