using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases
{
    public class Director:Empleado
    {
        public Director() { //Le estamos diciendo que, después de leer el constructor de Empleado (cuyo salario es de 800€) le añada 200€ más a dicho salario

            this.SalarioMinimo += 200;
        }

        //Con la palabra new es una forma de decirle que estamos sobrescribiendo el método 

        public override int GetDiasVacaciones() {

            Debug.WriteLine("GetDiasVacaciones() DIRECTOR");
            int dias = base.GetDiasVacaciones(); //Así llamamos al método de la clase empleado y almacenamos el valor que devuelve en una variable
            return dias + 8;
        }
    }
}
