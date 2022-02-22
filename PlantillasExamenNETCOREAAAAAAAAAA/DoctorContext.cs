using Microsoft.EntityFrameworkCore;
using MvcPracticaExamen2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen2.Data
{
    public class DoctorContext:DbContext
    {
        public DoctorContext(DbContextOptions<DoctorContext>options): base(options)
        {

        }

        public DbSet<Doctor> Doctores { get; set; }
    }
}
