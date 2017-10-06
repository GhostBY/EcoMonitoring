using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Login
{
    public class MailSMTP
    {
        public string UserName { get; set; }
        public string MailPassword { get; set;}
        public bool SSL {get; set; }
        public string SMTP {get; set; }
        public int PORT {get; set; }
        public MailSMTP(string UserName, string MailPassword, bool SSL, string SMTP, int PORT)
        {
            this.UserName = UserName;
            this.MailPassword = MailPassword;
            this.SMTP = SMTP;
            this.PORT = PORT;
            this.SSL = SSL;
        }
        public string Autorization()
        {
            SmtpClient client = new SmtpClient(SMTP,PORT);

            client.Credentials = new NetworkCredential(UserName, MailPassword);
            client.EnableSsl = true;
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(UserName);
            mail.To.Add(new MailAddress(UserName));
            mail.Subject = "EcoMon авторизация";
            mail.Body = "EcoMon авторизация";
            client.EnableSsl = true;
            try
            {
                client.Send(mail);
                return "True";
            }
            catch
            {
                return "False";
            }
        }
    }

  
}
