using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosExtra.Models;
using EjerciciosExtra.Context;

namespace EjerciciosExtra
{
    public partial class Hospital : Form
    {
        List<String> seleccionado;
        HospitalContext consult;
        public Hospital()
        {
            InitializeComponent();

            this.chkHospital.CheckedChanged += SeleccionarCheck;
            this.chkEnfermos.CheckedChanged += SeleccionarCheck;
            this.chkSalas.CheckedChanged += SeleccionarCheck;

            this.consult = new HospitalContext();
            this.seleccionado = new List<string>();
        }

        private void SeleccionarCheck(object sender, EventArgs e)
        {
            this.seleccionado.Clear();
            this.lstDatos.Columns.Clear();

            List<string> datos = new List<string>();

            foreach (Control c in this.panelHospital.Controls) {

                if (c is CheckBox) {

                    CheckBox ch = (CheckBox)c;

                    if (ch.Checked) {

                        this.seleccionado.Add(ch.Tag.ToString());
                    }
                }

                if (this.seleccionado.Count < 2) {

                    datos.Clear();

                    datos = this.consult.CargarColumnas(this.seleccionado);

                    foreach (string da in datos)
                    {

                        ColumnHeader col = new ColumnHeader();
                        col.Text = da;
                        col.Tag = da;

                        this.lstDatos.Columns.Add(col);
                    }

                }
                else if (this.seleccionado.Count >= 2) {

                    datos.Clear();

                    datos = this.consult.CargarColumnas(this.seleccionado).Distinct().ToList();

                    foreach (string da in datos) {

                        ColumnHeader col = new ColumnHeader();
                        col.Text = da;
                        col.Tag = da;

                        this.lstDatos.Columns.Add(col);
                    }

                }
                   
            }
        }
    }
}
