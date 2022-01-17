using MvcCoreMultiplesBBDD.Data;
using MvcCoreMultiplesBBDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreMultiplesBBDD.Repositories
{
    public class RepositoryEmpleados
    {
        private HospitalContext context;

        public RepositoryEmpleados(HospitalContext context) {

            this.context = context;
        }

        public List<Empleado> GetEmpleados() {

            var consulta = from datos in this.context.Empleados select datos;
            return consulta.ToList();
        }

        public Empleado FindEmpleado(int id) {

            return this.context.Empleados.FirstOrDefault(z => z.IdEmpleado == id);
        }

        public void DeleteEmpleado(int id) {

            Empleado emp = this.FindEmpleado(id);

            this.context.Empleados.Remove(emp);
            this.context.SaveChanges();
        }

        public void UpdateSalarioEmpleado(int idempleado,int incremento) {

            Empleado emp = this.FindEmpleado(idempleado);

            emp.Salario += incremento;
            this.context.SaveChanges();
        }
    }
}
