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
    public partial class form04DiaNacimientoSemana : Form
    {
        public form04DiaNacimientoSemana()
        {
            InitializeComponent();
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {

            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAnyo.Text);

            if (mes == 01) {

                mes = 13;
                anyo -= 1;

            }else if (mes == 02) {

                mes = 14;
                anyo -= 1;
            }

            int op1 = ((mes + 1) * 3) / 5;
            int op2 = anyo / 4;
            int op3 = anyo / 100;
            int op4 = anyo / 400;

            int op5 = dia + (mes * 2) + anyo + op1 + op2 - op3 + op4 + 2;
            int op6 = op5 / 7;
            int op7 = op5 - (op6 * 7);

            switch (op7) {

                case 0:
                    this.lblResul.Text = "SABADO";
                break;

                case 1:
                    this.lblResul.Text = "DOMINGO";
                break;

                case 2:
                    this.lblResul.Text = "LUNES";
                break;

                case 3:
                    this.lblResul.Text = "MARTES";
                break;

                case 4:
                    this.lblResul.Text = "MIERCOLES";
                break;
                case 5:
                    this.lblResul.Text = "JUEVES";
                break;
                case 6:
                    this.lblResul.Text = "VIERNES";
                break;
            }
        }
    }
}
