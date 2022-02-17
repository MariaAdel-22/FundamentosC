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

        public ServiceCatastro() {

            this.client = new ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoapClient
            (ReferenceCatrasto.CallejerodelasedeelectrónicadelcatastroSoapClient.EndpointConfiguration
            .Callejero_x0020_de_x0020_la_x0020_sede_x0020_electrónica_x0020_del_x0020_catastro_Soap);
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
    }
}
