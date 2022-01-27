using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreEmpleadosSession.Extensions
{
    public class ExtensionEmpleados
    {
        IWebHostEnvironment _env;

        public ExtensionEmpleados(IWebHostEnvironment _env) {

            this._env = _env;
        }
    }
}
