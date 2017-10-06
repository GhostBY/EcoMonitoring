using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net.Mail;
using System.Net;
namespace Login
{
    public class MailSMTPSend : MailSMTP
    {
        public string MailTo { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string File { get; set; }
        public MailSMTPSend(string UserName, string MailPassword, bool SSL, string SMTP, int PORT, string MailTo, string Subject, string Body, string File)
            :base(UserName,MailPassword,SSL,SMTP,PORT)
        {
            this.MailTo = MailTo;
            this.Subject = Subject;
            this.Body = Body;
            this.File = File;
        }
        public string Send()
        {
            try
            {
                SmtpClient client = new SmtpClient(UserName, PORT);

                client.Credentials = new NetworkCredential(UserName, MailPassword);
                client.EnableSsl = true;
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(UserName);
                mail.To.Add(new MailAddress(MailTo));
                mail.Subject = Subject;
                mail.Body = Body;
                client.EnableSsl = true;
                if (File != null && File != "")
                {
                    Attachment sendFile = new Attachment(File);
                    mail.Attachments.Add(sendFile);
                }
                return "True";
            }
            catch
            {
                return "False";
            }
        }
    }
}
