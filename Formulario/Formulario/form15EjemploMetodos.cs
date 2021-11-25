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
    public partial class form15EjemploMetodos : Form
    {
        public form15EjemploMetodos()
        {
            InitializeComponent();
        }

        int DobleNumero(int numero) {

            //Modificamos la variable del método
            numero = numero * 2;

            return numero;
        }

        //NO FUNCIONA PORQUE LOS WRAPPER NO TIENEN REFERENCIA, NO APUNTA A LA MISMA CLASE. POR ELLO SE UTILIZA MÉTODOS QUE TENGAN RETURN

        private void btnDoble_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int doble=this.DobleNumero(num);

            this.lblResultado.Text = "Doble: " + doble;
        }

        void CambiarColorBoton(Button boton) { //Al pasarle una clase, lo que pasa es que modifica el objeto que envío ya que el objeto que le pasamos apunta al mismo que modificamos en la llamada

            boton.BackColor = Color.Blue;
        }

        private void btnClaseReferencia_Click(object sender, EventArgs e)
        {

            this.CambiarColorBoton(this.btnClaseReferencia);
        }

        //PODEMOS HACER QUE UNA VARIABLE WRAPPER SEA REFERENCIADA MEDIANTE LA PALABRA REF

        void DobleNumeroReferencia(ref int numero) {

            numero = numero * 2;

        }

        private void btnReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);

            //En la llamada también tenemos que poner ref
            this.DobleNumeroReferencia(ref num);
            this.lblResultado.Text = "Doble: " + num;
        }

        private void lblMouse_MouseMove(object sender, MouseEventArgs e)
        {
            this.lblMouse.Text = "X: " + e.X + " - Y: " + e.Y; //Para mostrar las coordenadas del cursos al activarse el evento mouseMove
        }

        private void txtNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {

            //Debemos convertir la tecla de borrar en un char y para recoger cómo se escribe la tecla borrar lo tenemos que ver la propiedad Back usando Keys
            char teclaBorrar = (char)Keys.Back;

            if ((char.IsDigit(e.KeyChar) == false) && e.KeyChar!=teclaBorrar)
            { //Si el caracter que pulsado no es un número entonces haz que no salga en pantalla con el método handler

                e.Handled = true;
            }
            else {
                e.Handled = false;
            }
        }

        private void txtLetras_KeyPress(object sender, KeyPressEventArgs e)
        {

            char teclaBorrar = (char)Keys.Back;
            if (char.IsLetter(e.KeyChar) && e.KeyChar != teclaBorrar) //Es lo mismo que el anterior, lo único que cambia es preguntar por si es letra con IsLetter
            {

                e.Handled = true;
            }
            else {
                e.Handled = false;
            }
        }
    }
}
