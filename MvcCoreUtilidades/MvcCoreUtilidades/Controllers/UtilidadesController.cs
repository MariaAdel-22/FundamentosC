using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MvcCoreUtilidades.Providers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace MvcCoreUtilidades.Controllers
{
    public class UtilidadesController : Controller
    {
        private PathProvider path;
        private IConfiguration Configuration;

        public UtilidadesController(PathProvider path,IConfiguration configuration) {

            this.path = path;
            this.Configuration = configuration;
        }

        public IActionResult UploadFiles()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFilesAsync(IFormFile fichero)
        {
            //RECUPERAMOS UNA CARPETA TEMPORAL...
            string carpetatemporal = Path.GetTempPath();
            string filename = fichero.FileName;
            string path = this.path.MapPath(filename, Folders.Uploads);

            //CREAMOS EL FICHERO Y LO LEEMOS COMO UN STREAM

            using (Stream stream= new FileStream(path,FileMode.Create)) {

                await fichero.CopyToAsync(stream);
            }

            ViewBag.FileName = filename;
            ViewBag.Mensaje = "Fichero subido a " + path;
            return View();
        }

        public IActionResult SendMail() {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMail(string destinatario,string asunto,string mensaje,IFormFile fichero) {

            MailMessage mail = new MailMessage();

            //Esta es la forma de recoger un valor de appsettings
            string user = this.Configuration.GetValue<string>("MailSettings:user");

            //La cuenta de salida debe ser la misma que tenemos en APPSETTINGS, 
            mail.From = new MailAddress(user);

            //Los destinatarios son una coleccion
            mail.To.Add(new MailAddress(destinatario));
            mail.Subject = asunto;
            mail.Body = mensaje;

            //Comprobamos si tenemos adjuntos

            if (fichero != null) {

                string filename = fichero.FileName;
                string path = this.path.MapPath(filename, Folders.Temp);

                using (Stream stream = new FileStream(path, FileMode.Create)) {

                    await fichero.CopyToAsync(stream);
                }

                Attachment attachment = new Attachment(path);
                mail.Attachments.Add(attachment);
            }

            string host = this.Configuration.GetValue<string>("MailSettings:host");
            string password = this.Configuration.GetValue<string>("MailSettings:password");

            //Configuramos el cliente SMTP para enviar el correo

            SmtpClient cliente = new SmtpClient();
            cliente.Host = host;
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.UseDefaultCredentials = false;

            //Ahora tenemos que crear nuestras credenciales
            NetworkCredential credentials = new NetworkCredential(user, password);
            cliente.Credentials = credentials;
            cliente.Send(mail);

            ViewData["MENSAJE"] = "Mail enviado correctamente";

            return View();
        }
    }
}
