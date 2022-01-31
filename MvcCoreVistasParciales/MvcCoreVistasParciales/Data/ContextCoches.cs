using Microsoft.EntityFrameworkCore;
using MvcCoreVistasParciales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreVistasParciales.Data
{
    public class ContextCoches:DbContext
    {
        public ContextCoches(DbContextOptions<ContextCoches> option):base(option) { 
        }

        public DbSet<Coche> Coches { get; set; }
    }
}
