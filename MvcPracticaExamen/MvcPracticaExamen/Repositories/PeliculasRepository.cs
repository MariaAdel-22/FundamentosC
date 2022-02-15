using MvcPracticaExamen.Data;
using MvcPracticaExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen.Repositories
{
    public class PeliculasRepository
    {
        private PeliculasContext context;

        public PeliculasRepository(PeliculasContext context) {

            this.context = context;
        }

        public List<Genero> GetGeneros() {

            var consulta = from datos in this.context.Generos.AsEnumerable() select datos;

            return consulta.ToList();
        }

        public List<Nacionalidad> GetNacionalidades() {

            var consulta = from datos in this.context.Nacionalidades.AsEnumerable() select datos;
            return consulta.ToList();
        }

        public List<Pelicula> GetPeliculasGenero(int idG) {

            var consulta = from datos in this.context.Peliculas.AsEnumerable() where datos.IdGenero == idG select datos;

            return consulta.ToList();
        }

        public Pelicula GetPeliculaGenero(int id) {

            var consulta = from datos in this.context.Peliculas.AsEnumerable() where datos.IdPelicula == id select datos;

            return consulta.FirstOrDefault();
        }
    }
}
