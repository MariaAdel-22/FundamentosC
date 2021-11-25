using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Formulario
{
    public partial class form16ColeccionArrayList : Form
    {
        public form16ColeccionArrayList()
        {
            InitializeComponent();

            ArrayList coleccion = new ArrayList();

            coleccion.Add(this.button1);
            coleccion.Add(this.button2);
            coleccion.Add(this.button3);
            coleccion.Add(this.textBox1); //Añadimos otro elemento gráfico diferente a la colección


            //Queremos cambiar el color al primer elemento, RECUERDA: hay que castear a tipo button porque desde object no podremos acceder a la propiedad del objeto button

            //((Button)coleccion[0]).BackColor = Color.Fuchsia;

            //Como cambiar el color de todos los botones

            /*foreach (Button boton in coleccion) { //Ya directamente hace la abstracción en el foreach y podemos ir accediendo a la propiedad BackColor de todos los botones de la colección

                boton.BackColor = Color.Fuchsia;
            }*/

            foreach (Control ctrl in coleccion) { //Al tener añadido un object distinto en la colección, debemos subir un nivel más a la abstracción, utilizando con ello el objeto Control como término medio


                if (ctrl is Button)
                { //Le preguntamos si el object control es del tipo definido Button

                    ctrl.BackColor = Color.Fuchsia;

                }
                else {//Si no entonces cambia a otro color

                    ctrl.BackColor = Color.Aqua;
                }
            }

        }
    }
}
