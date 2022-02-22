using ServicioClientesClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Services
{
    public class ServiceClientesID
    {
        private ClientesContractClient client;

        public ServiceClientesID(ClientesContractClient client) {

            this.client = client;
        }

        public async Task<Cliente[]> GetClientes() {

            Cliente[] clientes = await this.client.GetClientesAsync();

            return clientes;
        }

        public async Task<Cliente> FindCliente(int id) {

            Cliente cliente = await this.client.FindClienteAsync(id);

            return cliente;
        }
    }
}
