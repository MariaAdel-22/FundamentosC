using Microsoft.AspNetCore.Http;
using MvcCoreUtilidades.Providers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreUtilidades.Helpers
{
    public class HelperUploadFiles
    {
        private PathProvider path;

        public HelperUploadFiles(PathProvider path) {

            this.path = path;
        }

        public async Task<string> UploadFileAsync(IFormFile formfile, Folders folder) {

            string filename = formfile.FileName;
            string path = this.path.MapPath(filename, folder);

            using (Stream stream = new FileStream(path, FileMode.Create)) {

                await formfile.CopyToAsync(stream);
            }

            return path;
        }

    }
}
