using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Empleado:Persona //Así es como se establece la herencia usando los dos puntos y de la clase que vamos a heredar
    {

        protected int SalarioMinimo { get; set; } //Utilizamos el ámbito a protected para que tengan acceso a esa clase solamente las que hereden de esta (como por ejemplo director)

        public virtual int GetDiasVacaciones() {


            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }

        public Empleado():base("otro","constructor"){

            Debug.WriteLine("Entramos al constructor EMPLEADO");

            this.SalarioMinimo = 800;
        }

        public Empleado(String nombre, String apellidos)
        {

            Debug.WriteLine("Constructor EMPLEADO parámetros");

            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.SalarioMinimo = 800;
            
        }

        public int GetSalarioMinimo() { //Creamos un métodos para que el formulario pueda acceder a la propiedad sin poder modificarla

            return this.SalarioMinimo;
        }
    }
}
