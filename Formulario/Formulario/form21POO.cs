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
            this.lstPropiedades.Items.Clear();
            Persona person = new Persona();

            person.Nombre = "Alumno NET";
            person.Edad = 28;

            person.Nacionalidad = Paises.Alemania;
            person.genero = TipoGenero.Femenino;

            person.MetodoParametroOpcional(7, parametroOpcional: 77);

            person.Domicilio = new Direccion(); //Para poder usar una propiedad que es compuesta (es decir, un objeto que hace referencia a otra clase) hay que inicializar el objeto
            person.Domicilio.Calle = "Calle Pez";

            person.Apellidos = "Core";

            //Propiedades y enumeración

            this.lstPropiedades.Items.Add("Nombre: "+person.Nombre);
            this.lstPropiedades.Items.Add("Edad: "+person.Edad);
            this.lstPropiedades.Items.Add("Genero: " + person.genero);
            this.lstPropiedades.Items.Add("Nacionalidad: " + person.Nacionalidad);

            //Métodos

            this.lstPropiedades.Items.Add("GetNombreCompleto():" + person.GetNombreCompleto());
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            this.lstPropiedades.Items.Clear();
            Empleado emp = new Empleado();

            emp.Nombre = "Empleado";
            emp.Apellidos = "Net Core";
            this.lstPropiedades.Items.Add("Empleado: "+ emp.GetNombreCompleto());
            this.lstPropiedades.Items.Add("Salario Minimo: "+emp.GetSalarioMinimo());
            this.lstPropiedades.Items.Add("Vacaciones: "+emp.GetDiasVacaciones());
        }

        private void btnDirector_Click(object sender, EventArgs e)
        {
            this.lstPropiedades.Items.Clear();
            Director dire = new Director();

            dire.Nombre = "Dir";
            dire.Apellidos = "ector";
            this.lstPropiedades.Items.Add("Objeto Director Nombre Apellido: "+dire.GetNombreCompleto());
            this.lstPropiedades.Items.Add("Salario mínimo: "+dire.GetSalarioMinimo());
            this.lstPropiedades.Items.Add("Vacaciones: "+dire.GetDiasVacaciones());
        }
    }
}
