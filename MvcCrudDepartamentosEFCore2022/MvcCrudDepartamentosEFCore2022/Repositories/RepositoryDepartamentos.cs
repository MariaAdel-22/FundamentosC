using MvcCrudDepartamentosEFCore2022.Data;
using MvcCrudDepartamentosEFCore2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCrudDepartamentosEFCore2022.Repositories
{
    public class RepositoryDepartamentos
    {
        private DepartamentosContext context;

        public RepositoryDepartamentos(DepartamentosContext context) {

            this.context = context;
        }

        public List<Departamento> GetDepartamentos() {

            var consulta = from datos in this.context.Departamentos select datos;
            return consulta.ToList();
        }

        public Departamento FindDepartamento(int id) { 
        
            var consulta= from datos in this.context.Departamentos where datos.IdDepartamento==id select datos;
            return consulta.FirstOrDefault();
        }

        private int GetMaxIdDepartamento()
        {

            //NECESITAMOS UN LAMBDA PARA RECUPERAR EL MAXIMO DE LA COLECION DbSet DE DEPARTAMENTOS

            int maximo = this.context.Departamentos.Max(x => x.IdDepartamento)+1;

            return maximo;
        }

        public void InsertarDepartamento(string nombre, string localidad) {

            Departamento dep = new Departamento();

            dep.IdDepartamento =this.GetMaxIdDepartamento();
            dep.Nombre = nombre;
            dep.Localidad = localidad;

            this.context.Departamentos.Add(dep);
            this.context.SaveChanges();
        }
        
        public void DeleteDepartamento(int id) {

            Departamento dep = this.FindDepartamento(id);

            this.context.Departamentos.Remove(dep);
            this.context.SaveChanges();
        }

        public void UpdateDepartamento(int id, string nombre, string localidad) {

            Departamento dep = this.FindDepartamento(id);

            dep.Nombre = nombre;
            dep.Localidad = localidad;

            this.context.SaveChanges();
        }
    }
}
