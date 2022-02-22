using ServiceCochesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Services
{
    public class ServiceCoches
    {
        CochesContractClient client;

        public ServiceCoches(CochesContractClient client) {

            this.client = client;
        }

        public async Task<Coche[]> GetCoches() {

            Coche[] coches= await this.client.GetCochesAsync();

            return coches;
        }

        public async Task<Coche> FindCoche(int id) {

            Coche coche = await this.client.FindCocheAsync(id);

            return coche;
        }
    }
}
