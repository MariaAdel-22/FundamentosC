using MvcNetCoreEF2022.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreEF2022.Repositories
{
    public class RepositoryHospitales
    {
        private HospitalesContext context;

        public RepositoryHospitales(HospitalesContext context) {

            this.context = context;
        }
    }
}
