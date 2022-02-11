using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcCoreLinqXML.Repositories
{
    public class RepositoryClientes
    {
        private XDocument document;
        private string path;

        public RepositoryClientes(PathProvider provider) {

            this.path = provider.MapPath("ClientesID.xml", Folders.Documents);
            this.document = XDocument.Load(path);
        }

        public List<Cliente> GetClientes() {

            var consulta = from datos in this.document.Descendants("CLIENTE") select datos;

            List<Cliente> clientes = new List<Cliente>();

            foreach (XElement elem in consulta) {

                Cliente client = new Cliente();

                client.IdCliente = int.Parse(elem.Element("IDCLIENTE").Value);
                client.Nombre = elem.Element("NOMBRE").Value;
                client.Email = elem.Element("EMAIL").Value;
                client.Direccion = elem.Element("DIRECCION").Value;
                client.Imagen = elem.Element("IMAGENCLIENTE").Value;

                clientes.Add(client);
            }

            return clientes;
        }

        public Cliente FindCliente(int id) {

            var consulta = from datos in this.document.Descendants("CLIENTE") where datos.Element("IDCLIENTE").Value == id.ToString() select datos;

            XElement dato = consulta.FirstOrDefault();

            Cliente cliente = new Cliente
            {

                IdCliente = int.Parse(dato.Element("IDCLIENTE").Value),
                Nombre = dato.Element("NOMBRE").Value,
                Direccion = dato.Element("DIRECCION").Value,
                Email = dato.Element("EMAIL").Value,
                Imagen = dato.Element("IMAGENCLIENTE").Value
            };

            return cliente;
        }

        public XElement FindElementCliente(string idcliente) {

            var consulta = from datos in this.document.Descendants("CLIENTE") where datos.Element("IDCLIENTE").Value == idcliente select datos;
            return consulta.FirstOrDefault();
        }

        public void DeleteCliente(int id) {

            XElement element = this.FindElementCliente(id.ToString());
            element.Remove();
            //Le paso la ruta para que actualice el documento
            this.document.Save(this.path);
        }

        public void UpdateCliente(int id,string nombre,string direccion,string email,string imagen) {

            XElement element = this.FindElementCliente(id.ToString());

            element.Element("NOMBRE").Value = nombre;
            element.Element("DIRECCION").Value = direccion;
            element.Element("EMAIL").Value = email;
            element.Element("IMAGENCLIENTE").Value = imagen;

            this.document.Save(this.path);
        }

        public void AddClient(int idCliente,string nombre,string direccion,string email,string imagen) {

            XElement raizCliente = new XElement("CLIENTE");

            //Debemos seguir el orden de estructura de etiquetas del XML
            raizCliente.Add(new XElement("IDCLIENTE", idCliente));
            raizCliente.Add(new XElement("NOMBRE",nombre));
            raizCliente.Add(new XElement("DIRECCION", direccion));
            raizCliente.Add(new XElement("EMAIL", email));
            raizCliente.Add(new XElement("IMAGENCLIENTE",imagen));

            //Insertamos dentro del DOCUMENT en el nivel que le corresponda (CLIENTE va dentro de CLIENTES que es la raíz del document)
            this.document.Element("CLIENTES").Add(raizCliente);
            
            this.document.Save(this.path);
        }
    }
}
