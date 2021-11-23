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
    public partial class form07ValidarMail : Form
    {
        public form07ValidarMail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string email = this.txtEmail.Text;
            string mensaje = "CORRECTO";
            int arroba = 0;
            int extension = 0;
            string dominio = "";
            char punto;
            int cont = 0;

            if (email.StartsWith('@') == true) {

                mensaje = "No debe contener un @ al inicio del email";
                this.lblResultado.ForeColor = Color.Red;
                cont += 1;
            } 
            
            if(email.EndsWith('@') == true){

                mensaje = "No debe contener un @ al final del email";
                this.lblResultado.ForeColor = Color.Red;
                cont += 1;
            }

            if (cont > 1) {

                mensaje = "No puede contener más de un @";
                this.lblResultado.ForeColor = Color.Red;
            }

            if (email.IndexOf('.',0) == -1) {

                mensaje = "Debe contener un punto";
                this.lblResultado.ForeColor = Color.Red;
            }

            arroba = email.IndexOf('@', 0);
            punto = email[arroba + 1];

            if (punto == '.')
            {

                mensaje = "No puede tener un punto detrás del @";
                this.lblResultado.ForeColor = Color.Red;

            }
            else {

                mensaje = "";
                this.lblResultado.ForeColor = Color.Black;
            }

            extension = email.IndexOf('.', 1);
            dominio = email.Substring(extension);


            if (dominio.Length < 2) {

                mensaje = "El dominio contiene de 2 a 4 caracteres";
                this.lblResultado.ForeColor = Color.Red;
            }

            this.lblResultado.Text = mensaje;
        }
    }
}
