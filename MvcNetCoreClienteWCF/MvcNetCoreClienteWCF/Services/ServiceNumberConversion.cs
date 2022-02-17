using ReferenceNumberConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ReferenceNumberConversion.NumberConversionSoapTypeClient;

namespace MvcNetCoreClienteWCF.Services
{
    public class ServiceNumberConversion
    {
        private NumberConversionSoapTypeClient client;

        public ServiceNumberConversion() {

            this.client = new NumberConversionSoapTypeClient(EndpointConfiguration.NumberConversionSoap);
        }

        public async Task<string> GetNumberToWords(int number) {

            NumberToWordsResponse response = await this.client.NumberToWordsAsync((ulong)number);

            string result = response.Body.NumberToWordsResult;

            return result;
        }
    }
}
