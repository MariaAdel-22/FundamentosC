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
    public partial class form20TemperaturasAnuales : Form
    {
        List<int> temperaturas;
        int tempMax;
        int temMin;
        int tempMedia;
        int suma;

        public form20TemperaturasAnuales()
        {
            InitializeComponent();
         
            temperaturas = new List<int>();
            
   
        }

        private void btnMeses_Click(object sender, EventArgs e)
        {
            this.lstMeses.Items.Clear();
            this.temperaturas.Clear();
            Random r = new Random();
            DateTime fecha = DateTime.Parse("01/01/2021"); //Al dejar establecida una fecha, podemos ir añadiendo meses para ir sacando cada mes y añadirlo en listbox


            for (int i = 1; i <= 12; i++)
            {

                int temAleatoria = r.Next(-16, 40); //Creamos los números aleatorios que iremos añadiendo a un list de tipo integer para almacenar las temperaturas
                this.temperaturas.Add(temAleatoria);//Añadimos el número al listado

                String nombreMes = fecha.ToString("MMMM"); //En una variable de tipo string, recogemos el nombre del mes utilizando el método toString("MMMM")
                this.lstMeses.Items.Add(nombreMes.ToUpper() + ":" + temAleatoria); //Vamos añadiendo los meses como items en el listBox
                fecha = fecha.AddMonths(1); //Vamos sumando un mes a la fecha para que vaya sacando todos los meses hasta llegar al último
            }
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
   
            this.tempMax = this.temperaturas[0]; //De esta forma podemos recoger desde el primer valor y comparar, pero una mejor manera es poner this.tempMax= int.MaxValue:
            this.temMin = this.temperaturas[0];
            this.tempMedia = 0;

            foreach (int temp in this.temperaturas) { //Vamos recorriendo todas las temperaturas almacenadas

                suma += temp;
                tempMax = Math.Max(temp,tempMax);
                temMin = Math.Min(temp, temMin);
            }

            tempMedia = suma / this.temperaturas.Count;

            this.txtMaxima.Text = tempMax.ToString();
            this.txtMinima.Text = temMin.ToString();
            int tempMediaTotal = suma / this.temperaturas.Count;
            this.txtMedia.Text = tempMediaTotal.ToString();

        }
    }
}
