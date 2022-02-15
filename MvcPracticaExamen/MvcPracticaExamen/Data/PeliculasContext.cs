using Microsoft.EntityFrameworkCore;
using MvcPracticaExamen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen.Data
{
    public class PeliculasContext:DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext>options):base(options) { 
        
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Nacionalidad> Nacionalidades { get; set; }

    }
}
