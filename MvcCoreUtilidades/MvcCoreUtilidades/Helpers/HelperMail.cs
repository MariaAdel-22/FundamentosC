using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace MvcCoreUtilidades.Helpers
{
    public class HelperMail
    {
        private IConfiguration configuration;

        public HelperMail(IConfiguration configuration) {

            this.configuration = configuration;
        }

        //A veces puede venir la imagen o no en el mail, para ello, haremos una sobrecarga de métodos 

        //Para configurar el mail 
        private MailMessage ConfigureMail(string destinatario,string asunto,string mensaje) {

            string from = this.configuration.GetValue<string>("MailSettings:user");
            
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(destinatario));
            mail.Subject = asunto;
            mail.Body = mensaje;
            mail.IsBodyHtml = true;

            return mail;
        }

        //Configuramos el smtp y enviamos el correo
        private void ConfigureSmtp(MailMessage mail) {

            string user = this.configuration.GetValue<string>("MailSettings:user");
            string psswd = this.configuration.GetValue<string>("MailSettings:password");
            string host = this.configuration.GetValue<string>("MailSettings:host");

            SmtpClient client = new SmtpClient();

            client.Port = 587;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;

            client.Host = host;
            NetworkCredential credentias = new NetworkCredential(user,psswd);
            client.Credentials = credentias;

            client.Send(mail);

        }

        public void SendMail(string destinatario,string asunto,string mensaje) {

            MailMessage mail = this.ConfigureMail(destinatario,asunto,mensaje);

            this.ConfigureSmtp(mail);
        }

        public void SendMail(string destinatario,string asunto,string mensaje,string filepath) {

            MailMessage mail = this.ConfigureMail(destinatario,asunto,mensaje);

            //Tenemos adjuntos

            Attachment attachment = new Attachment(filepath);
            mail.Attachments.Add(attachment);

            this.ConfigureSmtp(mail);
        }
    }
}
