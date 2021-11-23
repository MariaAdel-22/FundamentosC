using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Formulario
{
    public partial class form09InvertirTextoStringBuilder : Form
    {
        public form09InvertirTextoStringBuilder()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {

            string texto = this.txtTexto.Text;
            Stopwatch krono = new Stopwatch();

            krono.Start();

            int longitud = texto.Length;

            for (int i=0;i<longitud;i++) {

                //Recuperamos la última letra
                char letra = texto[longitud - 1];

                //Eliminamos la última letra
                texto = texto.Remove(longitud - 1, 1);

                //Insertamos la letra en cada posición del bucle
                texto = texto.Insert(i,letra.ToString());
            }

            this.txtTexto.Text = texto;
            krono.Stop();
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.TotalSeconds + "\nMilisegundos: "+krono.Elapsed.TotalMilliseconds; /*Con este objeto lo que hacemos es ver cuánto tiempo tarda el string en recoger
                                                                                                                                   todos los valores del for, ejecutando el objeto antes de comenzar la extracción
                                                                                                                                    de los char cambiando la posición de estas, hay que parar el objeto al 
                                                                                                                                     finalizar el bucle, y ya tras pararlo recogemos los segundos y milisegundos
                                                                                                                                       para ver cuanto ha tardado el proceso*/
        }

        private void btnStringBuilder_Click(object sender, EventArgs e)
        {
            StringBuilder texto = new StringBuilder();
            Stopwatch krono = new Stopwatch();

            texto.Append(this.txtTexto.Text);
            krono.Start();

            int longitud = texto.Length;

            for (var i=0;i<longitud;i++) {

                char letra = texto[longitud - 1];
                texto = texto.Remove(longitud-1,1);
                texto = texto.Insert(i, letra);

            }
            this.txtTexto.Text = texto.ToString();
            krono.Stop();
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.TotalSeconds + "\nMilisegundos: " + krono.Elapsed.TotalMilliseconds;

        }
    }
}
