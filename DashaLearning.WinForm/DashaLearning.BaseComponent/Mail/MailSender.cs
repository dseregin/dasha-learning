using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.BaseComponent.Mail
{
    public static class MailSender
    {
        public static void SendEmail(MailSettings settings, string[] to, string title, string content, bool isBodyHtml = false)
        {
            MailMessage mail = new MailMessage();
            try
            {
                mail.From = new MailAddress(settings.EmailUserName);
                foreach (var item in to)
                    mail.To.Add(new MailAddress(item));
                mail.Subject = title;
                mail.Body = content;
                mail.IsBodyHtml = isBodyHtml;
                SmtpClient client = new SmtpClient();
                client.Host = settings.EmailHost;
                client.Port = settings.EmailPort;
                client.EnableSsl = settings.EmailSSLEnabled;
                client.Credentials = new NetworkCredential(settings.EmailUserName, settings.EmailPassword);
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Send(mail);
            }
            catch (Exception e)
            {
                throw new Exception("Mail.Send: " + e.Message);
            }
            finally
            {
                mail.Dispose();
            }
        }
    }
}
