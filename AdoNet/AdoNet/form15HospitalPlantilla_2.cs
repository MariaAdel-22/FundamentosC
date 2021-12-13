using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNet.Context;
using AdoNet.Models;

namespace AdoNet
{
    public partial class form15HospitalPlantilla_2 : Form
    {
        HospitalContext consult;
        List<int> codigos;

        public form15HospitalPlantilla_2()
        {
            InitializeComponent();

            this.consult = new HospitalContext();
            this.codigos= new List<int>(); 

            this.CargarHospitales();
        }

        private void CargarHospitales() {

            List<Hospital> hosp = new List<Hospital>();

            hosp = this.consult.CargarHospitales();

            int y = 0;
            foreach (Hospital hos in hosp) {

                CheckBox chec = new CheckBox();

                chec.Text = hos.Nombre;
                chec.Tag = hos.Hospital_cod;

                y += 60;

                chec.Location = new Point(10, y);
                chec.CheckedChanged += CargarPlantilla;
                this.panel1.Controls.Add(chec);
            }
            
        }

        private void CargarPlantilla(object sender, EventArgs e)
        {
            this.codigos.Clear();
            this.listView1.Items.Clear();

            foreach (Control con in this.panel1.Controls) {

                if (con is CheckBox) {

                    CheckBox check = (CheckBox)con;

                    if (check.Checked) {

                        this.codigos.Add(int.Parse(check.Tag.ToString()));
                    }

                }
            }

            if (this.codigos.Count > 0) {

                List<Plantilla> plantillas = new List<Plantilla>();

                plantillas = this.consult.CargarPlantillaChck(this.codigos);

                foreach (Plantilla pl in plantillas)
                {

                    ListViewItem item = new ListViewItem();

                    item.Text = pl.Hospital_cod.ToString();
                    item.SubItems.Add(pl.Empleado_no.ToString());
                    item.SubItems.Add(pl.Apellido);
                    item.SubItems.Add(pl.Funcion);
                    item.SubItems.Add(pl.Salario.ToString());
                    item.SubItems.Add(pl.Sala_cod.ToString());
                    item.SubItems.Add(pl.T.ToString());

                    this.listView1.Items.Add(item);
                }
            }      
        }
    }
}
