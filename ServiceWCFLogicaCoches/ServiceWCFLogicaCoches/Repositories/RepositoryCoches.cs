using ServiceWCFLogicaCoches.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ServiceWCFLogicaCoches.Repositories
{
    public class RepositoryCoches
    {
        private XDocument document;

        public RepositoryCoches() {

            //TODO RECURSO INCRUSTADO SE RECUPERA COMO STREAM Y PARA RECUPERARLO DEBEMOS INDICAR EL NOMBRE DE NUESTRO 
            //NAMESPACE Y DE LA CARPETA/S DONDE ESTEN LOS RECURSOS INCRUSTADOS

            string resource = "ServiceWCFLogicaCoches.coches.xml";

            Stream stream = this.GetType().Assembly.GetManifestResourceStream(resource);

            this.document = XDocument.Load(stream);

        }

        public List<Coche> GetCoches() {

            var consulta = from datos in document.Descendants("coche")
                           select new Coche
                           {
                               IdCoche = int.Parse(datos.Element("idcoche").Value),
                               Marca=datos.Element("marca").Value,
                               Modelo=datos.Element("modelo").Value,
                               Imagen=datos.Element("imagen").Value
                           };
            return consulta.ToList();
        }

        public Coche FindCoche(int id)
        {

            return this.GetCoches().FirstOrDefault(x => x.IdCoche == id);
        }
    }
}
