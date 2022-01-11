using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoMvcCoreEF.Models
{
    public interface IDepartamentosContext
    {
        List<Departamento> GetDepartamentos();
        void InsertarDepartamento(int numero, string nombre, string localidad);
    }
}
