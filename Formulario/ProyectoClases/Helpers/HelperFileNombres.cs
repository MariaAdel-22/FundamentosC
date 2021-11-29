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
        //Cuando deseamos el archivo prueba.txt 

        public async List<String> ReadFileNombres(String path) {

            FileInfo file = new FileInfo(path);

            using (TextReader reader = file.OpenText()) {

                String contenido = await reader.ReadToEndAsync();

            }
        }
    }
}
