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
    public partial class Form05ClaseDateTime : Form
    {
        public Form05ClaseDateTime() //El constructor de la clase
        {
            InitializeComponent();//Este es el enlace para que se ejecute la clase designer (donde tenemos nuestro diseño)

            this.txtFecha.Text = DateTime.Now.ToString(); //Estamos convirtiendo a string la fecha actual (recogida con la propiedad Now del objeto DateTime)
        }

        private void chkFormato_CheckedChanged(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Parse(this.txtFecha.Text);

            if (this.chkFormato.Checked == true) //Comprobamos si está seleccionado el checkbox o no, si es true entonces el value del txtFecha será la fecha pero con formato corto (23/11/2021)
            {

                this.txtFecha.Text = fecha.ToShortDateString();
            }
            else {
                this.txtFecha.Text = fecha.ToLongDateString();
            }
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {

            int incremento = int.Parse(this.txtIncremento.Text);

            DateTime fecha = DateTime.Parse(this.txtFecha.Text); //Recogemos el valor de la caja txtFechaNueva y le añadimos días, añadiendo de nuevo en la caja la fecha con los dísa añadidos

            if (this.rbdDia.Checked == true)
            {

                fecha = fecha.AddDays(incremento);

            }
            else if (this.rbdMes.Checked == true)
            {

                fecha = fecha.AddMonths(incremento);
            }
            else {

                fecha = fecha.AddYears(incremento);
            }

            this.txtNuevaFecha.Text = fecha.ToString();
        }
    }
}
