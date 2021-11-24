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
    public partial class form11ColeccionesBuclesEjemplo : Form
    {
        public form11ColeccionesBuclesEjemplo()
        {
            InitializeComponent();
        }

        private void btnResp_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls) {

                c.BackColor = Color.Yellow;
            }
        }
    }
}
