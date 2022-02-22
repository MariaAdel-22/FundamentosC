using ServicioMetodosVarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Services
{
    public class ServiceMetodosVarios
    {
        MetodosVariosContractClient client;

        public ServiceMetodosVarios() {

            this.client = new MetodosVariosContractClient(MetodosVariosContractClient.
                EndpointConfiguration.BasicHttpBinding_IMetodosVariosContract);
        }

        public async Task<int[]> GetTablaMultiplicar(int numero) {

            int[] numeros= await this.client.GetTablaMultiplicarAsync(numero);

            return numeros;
        }
    }
}
