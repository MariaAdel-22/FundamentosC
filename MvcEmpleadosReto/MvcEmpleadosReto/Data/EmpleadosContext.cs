using MvcEmpleadosReto.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcEmpleadosReto.Data
{
    public class EmpleadosContext:DbContext
    {
        public EmpleadosContext() : base(@"Data Source=LAPTOP-IVMF1NEK\MSSQLSERVE;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=SA;Password=MCSD2021") { 
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}