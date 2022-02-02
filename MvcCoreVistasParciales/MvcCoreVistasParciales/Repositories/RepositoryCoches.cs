using MvcCoreVistasParciales.Data;
using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Repositories
{
    public class RepositoryCoches
    {
        public List<Coche> Cars;

        public RepositoryCoches() {

            this.Cars = new List<Coche> {

                new Coche{ IdCoche = 1, Marca="Pontiac", Modelo="Firebr", VelocidadMaxima=123},
                new Coche{ IdCoche=2,Marca="Lamborgini",Modelo="Distint",VelocidadMaxima=140},
                new Coche{IdCoche=3,Marca="Ferrari",Modelo="Testarrosa",VelocidadMaxima=300 },
                new Coche{ IdCoche=4,Marca="Ford",Modelo="Mustang",VelocidadMaxima=290}
            };
        }

        public List<Coche> GetCoches() {

            return this.Cars;
        }

        public Coche FindCoche(int idcoche) {

            Coche car = this.Cars.SingleOrDefault(z => z.IdCoche == idcoche);
            return car;
        }
    }
}
