using MvcNetCoreClienteWCF.Models;
using ReferenceCatrasto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MvcNetCoreClienteWCF.Services
{
    public class ServiceCatastro
    {
        private ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoapClient client;

        public ServiceCatastro(CallejerodelasedeelectrónicadelcatastroSoapClient client) {

            this.client = client;
        }

        public async Task<List<string>> GetProvincias() {

            ConsultaProvincia1 respo = await this.client.ObtenerProvinciasAsync();

            List<string> ProvinciaNames = new List<string>();

            foreach (XmlElement elem in respo.Provincias.ChildNodes) {

                foreach (XmlNode elem2 in elem.GetElementsByTagName("np")) {

                    string name = elem2.InnerText;
                    ProvinciaNames.Add(name);
                }
            }
           
            return ProvinciaNames;
        }

        public async Task<List<Provincia>> ProvinciasListado() {

            ConsultaProvincia1 response = await this.client.ObtenerProvinciasAsync();

            XmlNode nodo = response.Provincias;

            string xmlData = nodo.OuterXml;
            XDocument document = XDocument.Parse(xmlData);

            //ES IMPORTANTE TENER EL NAMESPACE PARA USAR LINQ PORQUE SINO NO CARGA LOS DATOS
            XNamespace ns = "http://www.catastro.meh.es/";

            List<Provincia> Provincias = new List<Provincia>();

            var consulta = from datos in document.Descendants(ns+"prov") select datos;

            foreach (XElement elem in consulta) {

                string cp = elem.Element(ns + "cpine").Value;
                string nombre = elem.Element(ns + "np").Value;
                Provincia prov = new Provincia { IdProvincia = cp, NombreProvincia = nombre };

                Provincias.Add(prov);
            }

            return Provincias;
        }

        public async void Municipios(string provincia,string municipio) {

            ConsultaMunicipio1 response = await this.client.ObtenerMunicipiosAsync(provincia,municipio);

            XmlNode nodo = response.Municipios;

            string dataXML = nodo.OuterXml;

            XDocument document = XDocument.Parse(dataXML);
            XNamespace ns = document.Root.Attribute("xmlns").Value;

            var consulta = from datos in document.Descendants("err") select datos;

            foreach (XElement elem in consulta) { 
            
            }
        }
    }
}
