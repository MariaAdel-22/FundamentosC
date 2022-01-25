using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreUtilidades.Providers
{
    public enum Folders
    {
        Uploads = 0, Images = 1, Documents = 2, Temp = 3
    }

    public class PathProvider
    {
        private IWebHostEnvironment _env;

        public PathProvider(IWebHostEnvironment _env) {

            this._env = _env;
        }

        public string MapPath(string filename,Folders folder) {

            string carpeta = "";

            if (folder == Folders.Uploads)
            {

                carpeta = "uploads";

            }
            else if (folder == Folders.Images)
            {

                carpeta = "images";

            } else if (folder == Folders.Documents) {

                carpeta = "documents";
            }

            string path = Path.Combine(this._env.WebRootPath, carpeta, filename);

            //La carpeta temporal
            if (folder == Folders.Temp) {

                path = Path.Combine(Path.GetTempPath(), filename);
            }

            return path;
        }
    }
}
