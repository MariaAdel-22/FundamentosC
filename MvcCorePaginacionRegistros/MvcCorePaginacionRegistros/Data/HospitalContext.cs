using Microsoft.EntityFrameworkCore;
using MvcCorePaginacionRegistros.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#region PRODECIMIENTOS Y VISTAS

/*
 CREATE PROCEDURE SP_PAGINAR_GRUPO_DEPARTAMENTOS(@POSICION INT)
AS
	SELECT DEPT_NO,DNOMBRE,LOC FROM V_DEPT_INDIVIDUAL WHERE POSICION >= @POSICION AND POSICION < (@POSICION + 2) 
GO


CREATE VIEW V_DEPT_INDIVIDUAL
AS
	SELECT CAST(ROW_NUMBER() OVER (ORDER BY DEPT_NO) AS INT) AS POSICION, ISNULL(DEPT_NO,0) AS DEPT_NO, DNOMBRE, LOC FROM DEPT
GO
 */
#endregion
namespace MvcCorePaginacionRegistros.Data
{
    public class HospitalContext: DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options):base(options) { 
        }

        public DbSet<VistaDepartamentoRegistro> VistaDepartamentos { get; set; }
    
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
