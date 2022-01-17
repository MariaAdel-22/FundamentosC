﻿using Microsoft.EntityFrameworkCore;
using MvcCoreProcedures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#region PROCEDIMIENTOS ENFERMOS

/*
 CREATE PROCEDURE GET_ENFERMOS 
AS
	SELECT * FROM ENFERMO
GO
 */

/*
 CREATE PROCEDURE FIND_ENFERMO(@INSCRIPCION NVARCHAR(30)) 
AS
	SELECT * FROM ENFERMO WHERE INSCRIPCION=@INSCRIPCION
GO
 */

/*
 CREATE PROCEDURE DELETE_ENFERMO(@INSCRIPCION NVARCHAR(30)) 
AS
	DELETE FROM ENFERMO WHERE INSCRIPCION=@INSCRIPCION
GO
 */
#endregion

#region PROCEDIMIENTOS DOCTOR

/*
 CREATE PROCEDURE GET_DOCTORES
AS
	SELECT * FROM DOCTOR;
GO
 */

/*
 CREATE PROCEDURE GET_ESPECIALIDADES
AS
	SELECT DISTINCT(ESPECIALIDAD) FROM DOCTOR;
GO
 */

/*
 CREATE PROCEDURE INCREMENTAR_SALARIO(@INCREMENTO INT,@ESPECIALIDAD NVARCHAR(200))
AS
	UPDATE DOCTOR SET SALARIO=SALARIO+@INCREMENTO WHERE ESPECIALIDAD=@ESPECIALIDAD
GO
 */

/*
 CREATE PROCEDURE FIND_DOCTORES_ESPECIALIDAD(@ESPECIALIDAD NVARCHAR(200))
AS
	SELECT * FROM DOCTOR WHERE ESPECIALIDAD=@ESPECIALIDAD
GO
 */
#endregion

namespace MvcCoreProcedures.Data
{
    public class EnfermosContext:DbContext
    {
        public EnfermosContext(DbContextOptions<EnfermosContext>options):base(options) { 
        }

        public DbSet<Enfermo> Enfermos { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<VistaEmpleado> VistaEmpleados { get; set; }
    }
}
