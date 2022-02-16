using ServicioCountries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcNetCoreClienteWCF.Services
{
    public class ServiceCountries
    {
        // El nombre del objeto siempre será cliente y se llamara con el nombre del servicio que hemos visto en la anterior pantalla.
        CountryInfoServiceSoapTypeClient client;

        public ServiceCountries() {

            this.client = new CountryInfoServiceSoapTypeClient(CountryInfoServiceSoapTypeClient.EndpointConfiguration.CountryInfoServiceSoap);
        }

        public async Task<tCountryCodeAndName[]> GetCountries() {

            ListOfCountryNamesByNameResponse response = await this.client.ListOfCountryNamesByNameAsync();

            tCountryCodeAndName[]objetos=response.Body.ListOfCountryNamesByNameResult;

            return objetos;
        }
    }
}
