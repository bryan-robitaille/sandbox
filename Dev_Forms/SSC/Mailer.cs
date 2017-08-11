using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace SSC
{

    /// <summary>
    /// Helper class for sending basic Emails - can be used on its own, or with MailTemplateHelper
    /// </summary>
    public class Mailer
    {

        private MailMessage m;

        public Mailer()
        {
            m = new MailMessage();
        }

        // not crazy about this dependency...
        private string DefaultSMTPServer
        {
            get { return SSC.Settings.DefaultSMTPServer; }
        }

        /// <summary>
        /// Should the email be sent as HTML or TXT
        /// </summary>
        public bool isHtml
        {
            set { m.IsBodyHtml = value; }
            get { return m.IsBodyHtml; }
        }

        /// <summary>
        /// Add a single "To" email
        /// </summary>
        public string To
        {
            set { m.To.Add(value); }
        }

        /// <summary>
        /// Add multiple To addresses
        /// </summary>
        /// <param name="email"></param>
        public void AddTo(string email)
        {
            m.To.Add(new MailAddress(email));
        }

        /// <summary>
        /// Set Sender/From
        /// </summary>
        public string From
        {
            set { m.Sender = m.From = new MailAddress(value); }
        }

        /// <summary>
        /// Set Subject
        /// </summary>
        public string Subject
        {
            set { m.Subject = value; }
        }

        /// <summary>
        /// Add CC emails
        /// </summary>
        /// <param name="email"></param>
        public void AddCC(string email)
        {
            m.CC.Add(new MailAddress(email));
        }

        /// <summary>
        /// Add BCC emails
        /// </summary>
        /// <param name="email"></param>
        public void AddBCC(string email)
        {
            m.Bcc.Add(new MailAddress(email));
        }

        /// <summary>
        /// Body Text
        /// </summary>
        public string Body
        {
            get { return Body; }
            set { m.Body = value; }
        }

        /// <summary>
        /// Send the Email
        /// </summary>
        public virtual void send()
        {
            SmtpClient sc = new SmtpClient();
            sc.Host = this.DefaultSMTPServer;
            sc.DeliveryMethod = SmtpDeliveryMethod.Network;
            sc.UseDefaultCredentials = false;
            sc.Port = 25;

            sc.Send(m);
        }


    }

}