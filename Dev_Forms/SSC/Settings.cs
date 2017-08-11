using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace SSC
{
    /// <summary>
    /// Global Settings class that caches appSettings keys from web.config
    /// </summary>
    public class Settings
    {

        /// <summary>
        /// SMTP Server Settings
        /// </summary>

        static private string _DefaultSMTPServer { get; set; }

        static public string DefaultSMTPServer
        {
            get { return _DefaultSMTPServer; }
        }

        static Settings()
        {
            if (WebConfigurationManager.AppSettings["SMTPServer"] == null)
                throw new ApplicationException("Missing SMTPServer setting in web.config");

            _DefaultSMTPServer = WebConfigurationManager.AppSettings["SMTPServer"];
        }

        /*
        public static string DefaultSMTPServer
        {
            get
            {
                return SSC.Environment.Production ? ProdSMTPServer : DevSMTPServer;
            }
        }
        */



    }

}