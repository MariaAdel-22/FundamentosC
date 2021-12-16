using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjerciciosExtra.Context;
using EjerciciosExtra.Models;

namespace EjerciciosExtra
{
    public partial class PlantillaDepartamento : Form
    {
        DepartamentosContext consult;
        List<Departamento> Dep;
        List<Empleado> Empleados;

        public PlantillaDepartamento()
        {
            InitializeComponent();
            
            this.consult = new DepartamentosContext();

            this.Empleados = new List<Empleado>();
            this.Dep= new List<Departamento>(); 

            this.CargarDepartamentos();
        }

        public void CargarDepartamentos() {

            this.Dep = this.consult.GetDepartamentos();
            int y = 0;

            foreach (Departamento dep in this.Dep) {

                RadioButton rad = new RadioButton();

                rad.Text = dep.Dnombre;
                rad.Tag = dep.Dept_no.ToString();
                rad.Width = 170;
                rad.Height = 30;

                y += 60;
                rad.Location = new Point(10, y);
                rad.CheckedChanged += CargarEmpleados;
                this.panel1.Controls.Add(rad);
                this.cmbDepartamentos.Items.Add(dep.Dnombre);
            }
        }

        private void CargarEmpleados(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
           
            this.Empleados.Clear();

            if (rad.Checked) {

                int cod_Dept = int.Parse(rad.Tag.ToString());
                this.Empleados = this.consult.GetEmpleado(cod_Dept);

                foreach (Empleado emp in this.Empleados) {

                    ListViewItem item = new ListViewItem();

                    item.Text = emp.Apellido;
                    item.Tag = emp.Emp_no;
                    item.SubItems.Add(emp.Oficio);
                    item.SubItems.Add(emp.Salario.ToString());

                    this.lsvEmpleados.Items.Add(item);
                }

            }
        }

        private void cmbDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Departamento dep = this.Dep[this.cmbDepartamentos.SelectedIndex];

            int cant_emp = this.consult.CantEmpleados(dep.Dept_no);

            this.numEmp.Text = cant_emp.ToString();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Empleado emp = new Empleado();

            emp.Apellido = this.txtApellido.Text;
            emp.Comision = int.Parse(this.txtComision.Text);

            Departamento dept= this.Dep[this.cmbDepartamentos.SelectedIndex];
            emp.Dept_no = dept.Dept_no;
            emp.Dir = int.Parse(this.txtDir.Text);
            emp.Emp_no = 1212;

            DateTime dat = this.Fecha.SelectionStart.Date;
            emp.Fecha_alt = dat;

            emp.Oficio = this.txtOficio.Text;
            emp.Salario = int.Parse(this.txtSsalario.Text);

            this.consult.InsertarEmpleado(emp);
            this.lsvEmpleados.Clear();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }

        private void lsvEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = this.lsvEmpleados.SelectedItems[0].Index;

            Empleado emp = this.Empleados[indice];

            this.txtApellido.Text=emp.Apellido;
            this.txtComision.Text = emp.Comision.ToString();
            this.txtDir.Text = emp.Dir.ToString();
            this.txtOficio.Text = emp.Oficio;
            this.txtSsalario.Text = emp.Salario.ToString();


           
        }
    }
}
