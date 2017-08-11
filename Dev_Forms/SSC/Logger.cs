using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Configuration;

namespace SSC
{


    /// <summary>
    /// This class implements basic logging functionality.  This is not a robust solution and in fact is not recommended for production use.  Produciton sites should make use of ELMAH.
    /// </summary>

    public class Logger
    {
        private string _LogFormat;
        private string _Path;
        private string _Type;

        private string _LogLevel = ConfigurationManager.AppSettings["LogLevel"] == null ? "INFO,WARN,ERROR" : ConfigurationManager.AppSettings["LogLevel"];

        public Logger()
        {

        }
        // string LangFile = HttpContext.Current.Server.MapPath("~/EmailTemplates/" + this.Template + "." + _LangString + (this.isHtml ? ".html" : "") + ".tpl");
        private void Log(string msg)
        {

            // if Logs folder doesn't exist, create it
            if (!System.IO.Directory.Exists(HttpContext.Current.Server.MapPath("~/Logs")))
            {
                System.IO.Directory.CreateDirectory(HttpContext.Current.Server.MapPath("~/Logs")); //   Path.Combine(Environment.CurrentDirectory, "Logs"));
            }

            _Path = HttpContext.Current.Server.MapPath("~/Logs/application.log"); // Path.Combine(Environment.CurrentDirectory, "Logs/application.log");

            _LogFormat = "[ " + _Type + " ] [ " + DateTime.Now.ToShortDateString().ToString() + " " + DateTime.Now.ToLongTimeString().ToString() + " ] ";

            using (StreamWriter sw = new StreamWriter(_Path, true))
            {
                sw.WriteLine(_LogFormat + msg);

                Console.WriteLine(_LogFormat + msg);
            }

        }

        public void Error(string msg)
        {
            _Type = "ERROR";
            if (_LogLevel.Contains("ERROR"))
            {
                Log(msg);
            }
        }

        public void Info(string msg)
        {
            _Type = "INFO";
            if (_LogLevel.Contains("INFO"))
            {
                Log(msg);
            }
        }

        public void Warning(string msg)
        {
            if (_LogLevel.Contains("WARN"))
            {
                _Type = "WARNING";
                Log(msg);
            }
        }

    }

}