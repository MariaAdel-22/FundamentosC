using MvcEmpleadosReto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcEmpleadosReto.Data
{
    public class EmpleadosContext:DbContext,IContext
    {
        public EmpleadosContext() : base(@"Data Source=LAPTOP-IVMF1NEK\MSSQLSERVE;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021") { 
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<EmpleadosContext>(null);
        }
        public DbSet<Empleado> empleados { get; set; }
    }
}