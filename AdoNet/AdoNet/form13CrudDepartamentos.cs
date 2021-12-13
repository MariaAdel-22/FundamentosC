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
    public partial class form13CrudDepartamentos : Form
    {
        DepartamentoContext consult;

        public form13CrudDepartamentos()
        {
            InitializeComponent();
            this.consult = new DepartamentoContext();

            List<Departamento> departamentos = new List<Departamento>();
            departamentos = this.consult.MostrarDepartamentos();

            foreach (Departamento dep in departamentos)
            {
                this.cmbDepartamento.Items.Add(dep.Nombre);
                
            }

        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lsvDepartamentos.Items.Clear();

            string nombre = this.cmbDepartamento.SelectedItem.ToString();
            Departamento dep = new Departamento();

            dep = this.consult.MostrarDepartamento(nombre);

            ListViewItem item = new ListViewItem();

            item.Text = dep.Numero.ToString();
            item.SubItems.Add(dep.Nombre);
            item.SubItems.Add(dep.Localidad);

            this.lsvDepartamentos.Items.Add(item);
            
         }

        private void lsvDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (this.lsvDepartamentos.SelectedItems.Count != 0) {

                ListViewItem item = this.lsvDepartamentos.SelectedItems[0];

                this.txtNumero.Text = item.Text;
                this.txtNombre.Text = item.SubItems[1].Text;
                this.txtLocalidad.Text = item.SubItems[2].Text;
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Departamento dep = new Departamento();

            dep.Numero = int.Parse(this.txtNumero.Text);
            dep.Nombre = this.txtNombre.Text;
            dep.Localidad = this.txtLocalidad.Text;

            this.consult.InsertarDepartamento(dep);

            //PARA ACTUALIZAR LOS DATOS (IRÍA MEJOR DENTRO DE UN MÉTODO)

            List<Departamento> departamentos = new List<Departamento>();
            departamentos = this.consult.MostrarDepartamentos();

            foreach (Departamento dept in departamentos)
            {
                this.cmbDepartamento.Items.Add(dept.Nombre);

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Departamento dept = new Departamento();

            dept.Numero = int.Parse(this.txtNumero.Text);
            dept.Nombre = this.txtNombre.Text;
            dept.Localidad = this.txtLocalidad.Text;

            this.consult.ModificarDepartamento(dept);

            //PARA ACTUALIZAR LOS DATOS (IRÍA MEJOR DENTRO DE UN MÉTODO)

            List<Departamento> departamentos = new List<Departamento>();
            departamentos = this.consult.MostrarDepartamentos();

            foreach (Departamento dep in departamentos)
            {
                this.cmbDepartamento.Items.Add(dep.Nombre);
            }

            this.txtNumero.Text = "";
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";
            this.lsvDepartamentos.Items.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ListViewItem seleccionado= this.lsvDepartamentos.SelectedItems[0];
            int dept_no = int.Parse(seleccionado.Text);

            this.consult.EliminarDepartamento(dept_no);

            //PARA ACTUALIZAR LOS DATOS (IRÍA MEJOR DENTRO DE UN MÉTODO)

            List<Departamento> departamentos = new List<Departamento>();
            departamentos = this.consult.MostrarDepartamentos();

            foreach (Departamento dep in departamentos)
            {
                this.cmbDepartamento.Items.Add(dep.Nombre);
            }

            this.txtNumero.Text = "";
            this.txtNombre.Text = "";
            this.txtLocalidad.Text = "";
            this.lsvDepartamentos.Items.Clear();

        }
    }
}
