using MvcClientesIDWCF.Models;
using MvcClientesIDWCF.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcClientesIDWCF
{
    public class ClientesClass : IClientesContract
    {
        private RepositoryCliente repo;

        public ClientesClass() {

            this.repo = new RepositoryCliente();
        }

        public Cliente FindCliente(int id)
        {
            return this.repo.FindCliente(id);
        }

        public List<Cliente> GetClientes()
        {
            return this.repo.GetClientes();
        }
    }
}
