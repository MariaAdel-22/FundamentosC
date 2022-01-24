using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace MvcCoreSession.Helpers
{
    public class HelperSession
    {
        //Lo que hacemos es convertir el objeto a un string con formato json
        public static string SerializeObject(object objeto)
        {
            string data = JsonConvert.SerializeObject(objeto);

            return data;
        }

        //Recibe el string con formato json y devolvemos el objeto deserializado
        public static T DeserializeObject<T>(string data) {

            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
