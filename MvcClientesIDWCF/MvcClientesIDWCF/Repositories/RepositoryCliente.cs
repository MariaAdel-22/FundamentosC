using MvcClientesIDWCF.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcClientesIDWCF.Repositories
{
    public class RepositoryCliente
    {
        private XDocument document;

        public RepositoryCliente() {

            string resource = "MvcClientesIDWCF.ClientesID.xml";

            Stream stream = this.GetType().Assembly.GetManifestResourceStream(resource);

            this.document = XDocument.Load(stream);
        }

        public List<Cliente> GetClientes()
        {
            var consulta=from datos in this.document.Descendants("CLIENTE") 
                         select new Cliente
                         {
                             IdCliente=int.Parse(datos.Element("IDCLIENTE").Value),
                             Nombre=datos.Element("NOMBRE").Value,
                             Direccion=datos.Element("DIRECCION").Value,
                             Email=datos.Element("EMAIL").Value,
                             Imagen=datos.Element("IMAGENCLIENTE").Value
                         };
            return consulta.ToList();
        }

        public Cliente FindCliente(int id) {

            return this.GetClientes().FirstOrDefault(x => x.IdCliente == id);
        }
    }
}
