using MvcCrudDepartamentosEFCore2022.Data;
using MvcCrudDepartamentosEFCore2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Repositories
{
    public class RepositoryEmpleados
    {
        private EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context) {

            this.context = context;
        }

        //Consulta para mostrar todos los empleados
        public List<Empleado> GetEmpleados() {

            var consulta = from datos in this.context.Empleados select datos;
            return consulta.ToList();
        }

        //Consulta para mostrar empleados por su oficio

        public List<Empleado> GetEmpleadosOficio(string oficio) {

            var consulta = from datos in this.context.Empleados where datos.Oficio == oficio select datos;
            return consulta.ToList();
        }

        //Consulta para mostrar los diferentes oficios
        public List<string> GetOficios() {

            var consulta = (from datos in this.context.Empleados select datos.Oficio).Distinct();
            return consulta.ToList();
        }

        //Consulta para modificar el salario de los empleados por su oficio
        public void IncrementarSalarioOficio(string oficio, int incremento) {

            //Extraemos del context todos los empleados por su oficio
            List<Empleado> empleados = this.GetEmpleadosOficio(oficio);

            //Tenemos que recorrer cada empleado para ir modificando su salario
            foreach (Empleado emp in empleados) {

                emp.Salario += incremento;
            }
            this.context.SaveChanges();
        }
    }
}
