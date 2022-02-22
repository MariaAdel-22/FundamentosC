using MvcPracticaExamen2.Data;
using MvcPracticaExamen2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen2.Repositories
{
    public class RepositoryDoctor
    {
        private DoctorContext context;

        public RepositoryDoctor(DoctorContext context) {

            this.context = context;
        }

        public List<Doctor> GetDoctores() {

            var consulta = from datos in this.context.Doctores select datos;
            return consulta.ToList();
        }

        public List<Doctor> GetDoctoresEspeciales(int salario) {

            var consulta = from datos in this.context.Doctores where datos.Salario >= salario select datos;

            return consulta.ToList();
        }

        public List<Doctor> GetDoctoresNOEspeciales(int salario)
        {

            var consulta = from datos in this.context.Doctores where datos.Salario < salario select datos;
            return consulta.ToList();
        }


        public Doctor FindDoctor(int IdDoctor) {

            var consulta = from datos in this.context.Doctores where datos.IdDoctor == IdDoctor select datos;

            return consulta.FirstOrDefault();
        }

        public void ModificarDoctor(Doctor doc) {

            this.context.Doctores.Add(doc);
            this.context.SaveChanges();
        }

        public void EliminarDoctor(int id) {

            var consulta = from datos in this.context.Doctores where datos.IdDoctor == id select datos;

            this.context.Doctores.Remove(consulta.FirstOrDefault());
            this.context.SaveChanges();

        }

        public int MaximoSalario() {

            var consulta = (from datos in this.context.Doctores select datos.Salario).Max();

            return consulta;
        }
    }
}
