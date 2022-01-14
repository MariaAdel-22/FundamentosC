using Microsoft.EntityFrameworkCore;
using MvcCoreProcedures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


#region PROCEDIMIENTOS

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
 CREATE PROCEDURE FIND_ENFERMO(@INSCRIPCION NVARCHAR(30)) 
AS
	SELECT * FROM ENFERMO WHERE INSCRIPCION=@INSCRIPCION
GO
 */
#endregion

namespace MvcCoreProcedures.Data
{
    public class EnfermosContext:DbContext
    {
        public EnfermosContext(DbContextOptions<EnfermosContext>options):base(options) { 
        }

        DbSet<Enfermo> enfermos;
    }
}
