using MvcCoreCrudHospitales.Data;
using MvcCoreCrudHospitales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreCrudHospitales.Repositories
{
    public class RepositoryHospital
    {
        private HospitalContext context;

        public RepositoryHospital(HospitalContext context) {

            this.context = context;
        }

        public List<Hospital> GetHospitales() {

            var consulta = from datos in this.context.Hospitales select datos;

            return consulta.ToList();
        }

        public Hospital FindHospital(int id) {

            var consulta = from datos in this.context.Hospitales where datos.IdHospital == id select datos;
            return consulta.First();
        }

        private int GetMaxId() {

            int maxId = this.context.Hospitales.Max(x => x.IdHospital + 1);
            return maxId;
        }

        public void InsertarHospital(string nombre, string direccion, string tel,int camas) {

            Hospital hosp = new Hospital();

            hosp.IdHospital = this.GetMaxId();
            hosp.Nombre = nombre;
            hosp.Direccion = direccion;
            hosp.Telefono = tel;
            hosp.Camas = camas;

            this.context.Hospitales.Add(hosp);
            this.context.SaveChanges();
        }

        public void EliminarHospital(int id) {

            Hospital hosp = this.FindHospital(id);

            this.context.Hospitales.Remove(hosp);
            this.context.SaveChanges();
        }

        public void ModificarHospital(int id,string nombre, string direccion, string telefono, int camas) {

            Hospital hosp = this.FindHospital(id);

            hosp.Nombre = nombre;
            hosp.Direccion = direccion;
            hosp.Telefono = telefono;
            hosp.Camas = camas;

            this.context.SaveChanges();
        }

        public DoctoresResumen getResumen(int idHospital) {

            List<Doctor> doctores = this.context.Doctores.Where(x => x.IdHospital == idHospital).ToList();

            if (doctores.Count() == 0)
            {

                return null;
            }
            else {

                DoctoresResumen res = new DoctoresResumen();

                res.MaximoSalario = doctores.Max(s => s.Salario);
                res.MediaSalario = doctores.Average(a => a.Salario);
                res.SumaSalarial = doctores.Sum(su => su.Salario);
                res.docs = doctores;

                return res;
            }
        }
    }
}
