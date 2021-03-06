using MvcNetCoreEF2022.Data;
using MvcNetCoreEF2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Repositories
{
    public class RepositoryDoctores
    {
        private DoctoresContext context;

        public RepositoryDoctores(DoctoresContext context) {

            this.context = context;
        }

        public List<Doctor> GetDoctoresHospital(int idhospital) {

            var consulta = from datos in this.context.Doctores where datos.IdHospital == idhospital select datos;

            return consulta.ToList();
        }

        public List<Doctor> GetDoctores() {

            var consulta = from datos in this.context.Doctores select datos;
            return consulta.ToList();
        }

        public List<Doctor> FindDoctoresSalario(int salario) {

            var consulta = from datos in this.context.Doctores where datos.Salario >= salario select datos;

            if (consulta.Count() == 0)
            {

                return null;
            }
            else
            {

                return consulta.ToList();
            }
        }
    }
}
