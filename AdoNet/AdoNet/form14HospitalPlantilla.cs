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
    public partial class form14HospitalPlantilla : Form
    {
        HospitalContext consult;
        public form14HospitalPlantilla()
        {
            InitializeComponent();
            this.consult = new HospitalContext();
            this.CargarH();
        }

        private void CargarH() {

            List<Hospital> hospitales = new List<Hospital>();

            hospitales = this.consult.CargarHospitales();

            int y = 0;

            foreach (Hospital hosp in hospitales) {

                RadioButton radio = new RadioButton();

                radio.Text = hosp.Nombre;
                radio.Name = hosp.Hospital_cod.ToString();

                radio.Height = 60;
               
                y += 60;
                radio.Location = new Point(10, y);

                radio.CheckedChanged += CargarPlantilla;
                this.panel1.Controls.Add(radio);

            }
        
        }

        private void CargarPlantilla(object sender, EventArgs e)
        {
            RadioButton rad = new RadioButton();

            rad = (RadioButton)sender;

            if (rad.Checked) {

                int hospital_cod = int.Parse(rad.Name);
              
            }
            
        }
    }
}
