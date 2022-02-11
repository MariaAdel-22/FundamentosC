using MvcCoreLinqXML.Models;
using MvcCoreLinqXML.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MvcCoreLinqXML.Repositories
{
    public class RepositoryJoyeria
    {
        private XDocument document;

        public RepositoryJoyeria(PathProvider provider) {
            
            string filename = "joyerias.xml";
            string path = provider.MapPath(filename, Folders.Documents);
            this.document = XDocument.Load(path);
        }

        public List<Joyeria> GetJoyerias() {

            var consulta = from datos in this.document.Descendants("joyeria") select datos;

            List<Joyeria> joyerias = new List<Joyeria>();

            foreach (XElement elem in consulta) {

                Joyeria joyeria = new Joyeria();

                //Para acceder a una etiqueta usamos XElement, y para acceder al atributo usamos Atribute
                joyeria.Nombre = elem.Element("nombrejoyeria").Value;
                joyeria.CIF = elem.Attribute("cif").Value;
                joyeria.Telefono = elem.Element("telf").Value;
                joyeria.Direccion = elem.Element("direccion").Value;

                joyerias.Add(joyeria);
            }

            return joyerias;
        }
    }
}
