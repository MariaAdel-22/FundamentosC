using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoClases.Helpers
{
    public class HelperFileNombres
    {
        //Cuando deseamos el archivo prueba.txt. Si los métodos son async, debemos devolver Task<Tipo>, Task es una clase que debemos usar para trabajar con asíncronos

        public async Task<List<String>> ReadFileNombres(String path) {

            FileInfo file = new FileInfo(path);
            String contenido = "";

            using (TextReader reader = file.OpenText()) {

                contenido= await reader.ReadToEndAsync();
                reader.Close();
            }

            return this.GetNombres(contenido);
        }

        private List<String> GetNombres(String data) {

            string[] nombres = data.Split(',');
            List<String> listanombres = new List<string>(nombres);

            return listanombres;
        }

        //Si es un método tipo void sólo se escribe Task en lo sasync 
        public async Task WriteFileNombres(String path,string data) {

            FileInfo file = new FileInfo(path);

            using (TextWriter writer = file.CreateText()) {

                await writer.WriteAsync(data);
                await writer.FlushAsync();
                writer.Close();

            }
        }


    }
}
