using Microsoft.AspNetCore.Http;
using MvcCoreSession.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSession.Extensions
{
    public static class SessionExtension
    {
        //Como crear un método setobject en session. NECESITAMOS en el método el tipo de objeto
        public static void SetObject(this ISession session,string key,object value) {

            string data = HelperSession.SerializeObject(value);

            session.SetString(key, data);

        }

        public static T GetObject<T>(this ISession session,string key) {

            string data = session.GetString(key);

            //En session una clase no existe.Si no encuentra la key devolvemos null

            if (data == null)
            {

                //Se devuelve el valor por defecto del generico

                return default(T);
            }
            else { 
            
                return HelperSession.DeserializeObject<T>(data);
            }
        }
    }
}
