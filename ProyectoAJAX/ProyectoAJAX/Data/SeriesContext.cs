using Microsoft.EntityFrameworkCore;
using ProyectoAJAX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAJAX.Data
{
    public class SeriesContext:DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options) : base(options) { 
        
        }

        public DbSet<Serie> Series { get; set; }
    }
}
