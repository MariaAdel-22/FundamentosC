﻿using Microsoft.EntityFrameworkCore;
using MvcPracticasVistasParcialesCasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticasVistasParcialesCasa.Data
{
    public class EmpleadosContext:DbContext
    {
        public EmpleadosContext(DbContextOptions<EmpleadosContext> options) : base(options) { 
        
        }
        public DbSet<Empleado> Empleados { get; set; }
    }
}
