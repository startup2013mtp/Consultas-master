using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Framawork
{
    public class Mail
    {
        public static void enviaEmail() {
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.Subject = "Solicitação de oramento";
            msg.From = new System.Net.Mail.MailAddress("matheusny2006@gmail.com");
            msg.To.Add(new System.Net.Mail.MailAddress("tizinho29@gmail.com"));
            msg.Body = TemplateHtml.mountEmail();
            msg.IsBodyHtml = true;
            System.Net.Mail.SmtpClient smpt = new System.Net.Mail.SmtpClient();
            smpt.Host = "smtp.gmail.com";
            smpt.Port = 587;
            smpt.EnableSsl = true;
            smpt.Credentials = new System.Net.NetworkCredential("matheusny2006@gmail.com", "gmailchains2013");
            smpt.Send(msg);
        }
    }
}
