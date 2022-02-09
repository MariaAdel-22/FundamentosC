using Microsoft.EntityFrameworkCore;
using MvcSeguridadDoctores.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSeguridadDoctores.Data
{
    public class EnfermosContext:DbContext
    {
        public EnfermosContext(DbContextOptions<EnfermosContext>options):base(options) { 
        }

        public DbSet<Enfermo> Enfermos { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
    }
}
