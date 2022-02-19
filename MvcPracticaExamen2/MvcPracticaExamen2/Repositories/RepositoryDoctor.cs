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

        public Doctor FindDoctor(int IdDoctor) {

            var consulta = from datos in this.context.Doctores where datos.IdDoctor == IdDoctor select datos;

            return consulta.FirstOrDefault();
        }

    }
}
