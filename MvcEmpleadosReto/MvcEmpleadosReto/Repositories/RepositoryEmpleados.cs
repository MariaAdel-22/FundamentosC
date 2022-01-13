using MvcEmpleadosReto.Data;
using MvcEmpleadosReto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEmpleadosReto.Repositories
{
    public class RepositoryEmpleados:IRepository
    {
        private EmpleadosContext context;

        public RepositoryEmpleados(EmpleadosContext context) {

            this.context = context;
        }

        public List<Empleado> GetEmpleados() {

            var consulta = from datos in this.context.empleados select datos;
            return consulta.ToList();
        
        }

        public Empleado findEmpleado(int id) {

            var consulta = from datos in this.context.empleados where datos.IdEmpleado == id select datos;

            return consulta.First();
            
        }
        public void ModificarEmpleado(int id,string apellido, string oficio, int salario) {

            Empleado emp = this.findEmpleado(id);

            emp.Apellido = apellido;
            emp.Oficio = oficio;
            emp.Salario = salario;

            this.context.SaveChanges();
        }
    }
}