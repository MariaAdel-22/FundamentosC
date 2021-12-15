using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Matematicas.Models
{
    public class Multiplicacion
    {
        public int Numero { get; set; }

        public List<string> Operacion(int num1) {

            List<String> Op = new List<string>();

            for (int i=0;i<=10;i++) {

                Op.Add(num1.ToString()+" * "+i);
            }

            return Op;
        }

        public List<int> Resultado(int num1) {

            List<int> res = new List<int>();

            for (int i=0;i<=10;i++) {

                res.Add(num1*i);
            }

            return res;
        }
    }
}
