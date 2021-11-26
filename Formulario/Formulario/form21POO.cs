using ProyectoClases;
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
    public partial class form21POO : Form
    {
        public form21POO()
        {
            InitializeComponent();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
        }
    }
}
