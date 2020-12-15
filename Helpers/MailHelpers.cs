using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace YourTour.Helpers
{
    public class  MailHelpers
    {
       public void SendMail(string to, string subject, string body)
        {
            using(MailMessage mail  = new MailMessage()){
                mail.From = new MailAddress("yourtour.travel.agent@gmail.com");
                mail.To.Add(to);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                using (SmtpClient client = new SmtpClient("smtp.gmail.com",587))
                {
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("yourtour.travel.agent@gmail.com", "Shiroe1058");
                    client.EnableSsl = true;
                    client.Send(mail);
                }
            }
        }
    }
}
