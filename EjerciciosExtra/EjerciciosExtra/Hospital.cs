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

                    List<string> datosR = new List<string>();

                    List<int> contador = new List<int>();

                    datos = this.consult.CargarColumnas(this.seleccionado);
                    

                    for (int i=0; i< datos.Count;i++) {

                        if (datos[i].Contains("HOSPITAL_COD"))
                        { 
                            contador.Add(datos.IndexOf(datos[i]));

                            for (int j=0; j< contador.Count;j++) {

                                if (contador.Count <=1) {

                                   datosR.Add(datos[i]);
                                    
                                }
                                else { 

                                    int val1 = contador[j];
                                    int val2 = contador[val1 + j];

                                    if (val1.Equals(val2)) {

                                        datosR.Add(datos[i]);
                                    }
                                }
                                
                            }


                        } else if (datos[i].Contains("SALA_COD")) {

                            contador.Add(datos.IndexOf(datos[i]));

                            if (contador[0].Equals(contador[1]))
                            {

                                datosR.Add(datos[i]);
                            }
                            else
                            {
                                contador.Clear();
                            }

                        }
                        else {

                            datosR.Add(datos[i]);
                        }
                        
                    }

                    foreach (string dat in datosR) {

                        ColumnHeader col = new ColumnHeader();
                        col.Text = dat;
                        col.Tag = dat;

                        this.lstDatos.Columns.Add(col);

                    }

                }
                   
            }
        }
    }
}
