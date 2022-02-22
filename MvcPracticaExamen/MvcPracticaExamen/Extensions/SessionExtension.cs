using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPracticaExamen.Extensions
{
    public static class SessionExtension
    {
        public static void SerializeObject(this ISession session, string key, object value) {

            string data = JsonConvert.SerializeObject(value);
            session.SetString(key, data);

        }

        public static T DeserializeObject<T>(this ISession session,string key) {

            string data = session.GetString(key);

            if (data == null) {

                return default(T);
            }
            return JsonConvert.DeserializeObject<T>(data);
        }
    }
}
