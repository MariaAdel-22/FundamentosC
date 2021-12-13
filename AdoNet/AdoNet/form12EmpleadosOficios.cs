using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet.Models;
using AdoNet.Context;

namespace AdoNet
{
    public partial class form12EmpleadosOficios : Form
    {
        EmpleadosContext consult;

        public form12EmpleadosOficios()
        {
            InitializeComponent();

            consult = new EmpleadosContext();

            List<String> Oficios = new List<string>();
            Oficios = this.consult.GetOficios();

            foreach (string of in Oficios) {

                this.cmbOficios.Items.Add(of);
            }
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string oficio = this.cmbOficios.SelectedItem.ToString();

            List<Empleado> empleados = new List<Empleado>();

            empleados = this.consult.GetEmpleadosOficio(oficio);

            lsvEmpleados.Items.Clear();

            foreach (Empleado em in empleados) {

                ListViewItem item = new ListViewItem();
                item.Text = em.Apellido;
                item.SubItems.Add(em.Oficio);
                item.SubItems.Add(em.Salario.ToString());

                lsvEmpleados.Items.Add(item);
            }
        }
    }
}
