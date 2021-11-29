using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperFileNombresOK
    {
        private string _path;
        public List<String> Nombres { get; set; }

        public HelperFileNombresOK(string path) {

            this._path = path;

            //De esta forma podemos rellenar directamente la coleccion
            this.ReadFile();

        }

        private void ReadFile() {

            FileInfo file = new FileInfo(this._path);

            using (TextReader reader= file.OpenText()) {

                String contenido = reader.ReadToEnd();
                string[] nombres =contenido.Split(',');
                this.Nombres = new List<string>(nombres);
            }
        }

        public void WriteFile() {

            String data = "";

            foreach (String name in this.Nombres) {

                data += name + ",";
            }

            data = data.Trim(',');


            FileInfo file = new FileInfo(this._path);

            using (TextWriter writer= file.CreateText()) {

                writer.Write(data);
                writer.Flush();
                writer.Close();

            }
        }
     
    }
}
