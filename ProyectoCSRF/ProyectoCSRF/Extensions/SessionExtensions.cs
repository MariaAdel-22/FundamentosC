﻿using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCSRF.Extensions
{
    public static class SessionExtensions
    {
        public static void GetObject(this ISession session,string key,object value) {

            string data = JsonConvert.SerializeObject(value);
            session.SetString(key, data);
        }

        public static T GetObject<T>(this ISession session, string key) {

            string data = session.GetString(key);

            if (data == null)
            {

                return default(T);
            }
            else {

                return JsonConvert.DeserializeObject<T>(data);
            }
        }
    }
}
