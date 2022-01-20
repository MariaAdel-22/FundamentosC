using Microsoft.EntityFrameworkCore;
using MvcCoreMultiplesBBDD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

#region PROCEDIMIENTOS SQL
/*
 CREATE PROCEDURE SP_DELETE_EMPLEADO (@IDEMPLEADO INT)
AS
	DELETE FROM EMP WHERE EMP_NO=@IDEMPLEADO
GO
 */
#endregion

#region PROCEDIMIENTOS ORACLE

/*
 CREATE OR REPLACE PROCEDURE SP_DELETE_EMPLEADO (IDEMPLEADO INT)
AS
BEGIN
       DELETE FROM EMP WHERE EMP_NO=IDEMPLEADO;
       COMMIT;
END;
 */

/*
 CREATE OR REPLACE PROCEDURE SP_UPDATE_SALARIO_EMP
(IDEMPLEADO INT, INCREMENTO INT)
AS
BEGIN
  UPDATE EMP SET SALARIO=SALARIO + INCREMENTO WHERE EMP_NO=IDEMPLEADO;
  COMMIT;
END;
 */
#endregion

namespace MvcCoreMultiplesBBDD.Data
{
    public class HospitalContext:DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext>options):base(options) { 
        
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
