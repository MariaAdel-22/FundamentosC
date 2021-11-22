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
    public partial class Form02SumarNumeros : Form
    {
        public Form02SumarNumeros()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            int num1, num2;
            num1 = int.Parse(this.txt1.Text); //Estamos recogiendo el valor del input y convirtiéndolo a tipo int
            num2 = int.Parse(this.txt2.Text);

            int suma = num1 + num2;
            this.lblResultado.Text = "La suma es: "+suma;//Otra forma de parsearlo es cuando le añadimos un string delante, de manera implícita hace el tostring()
        } 

    }
}
