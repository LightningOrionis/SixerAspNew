using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Sixerr.Services
{
    public class EmailService
    {
        //System.Net.Mail.SmtpClient
        public void Send(string to_address, string body, string subject)
        {
            MailMessage message = new MailMessage();
            // message.IsBodyHtml = true;
            message.From = new MailAddress("krasovsky17igor@gmail.com", subject);
            message.To.Add(to_address);
            message.Subject = "Test";
            message.Body = body;
            using (SmtpClient client = new SmtpClient("smtp.gmail.com"))
            {
                client.Credentials = new NetworkCredential("krasovsky17igor@gmail.com", "3091494ig");
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(message);
            }                    
        }
    }
}
