using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Specialized;
using System.Configuration;

namespace SSC
{

    public enum ENV { Local, Development, Production };

    /// <summary>
    /// Summary description for Environment
    /// </summary>
    public static class Environment
    {

        /// <summary>
        /// This class provides static methods for checking the ENV variable of an application.  ENV must be registered in the Web.config.  If it is not set, ENV will default to Local.  Possible values: Development, Production, Local.
        /// </summary>

        public static bool Production { get { return GetCurrentEnvironment == SSC.ENV.Production ? true : false; } }
        public static bool Development { get { return GetCurrentEnvironment == SSC.ENV.Development ? true : false; } }
        public static bool Local { get { return GetCurrentEnvironment == SSC.ENV.Local ? true : false; } }

        public static string ENV { get { return GetCurrentEnvironment.ToString(); } }

        private static ENV GetCurrentEnvironment
        {
            get
            {

                if (ConfigurationManager.AppSettings["ENV"] == "Production")
                    return SSC.ENV.Production;
                else if (ConfigurationManager.AppSettings["ENV"] == "Development")
                    return SSC.ENV.Development;
                else
                    return SSC.ENV.Local;

                /*
                if (System.Web.HttpContext.Current.Request.Url.Authority.ToLower().StartsWith("localhost") || System.Web.HttpContext.Current.Request.Url.Authority.ToLower().StartsWith("127.0.0.1"))
                    return SSC.ENV.Local;
                else if (System.Web.HttpContext.Current.Request.Url.Authority.ToLower().Contains("-dev"))
                    return SSC.ENV.Development;
                else
                    return SSC.ENV.Production;
                */
            }

        }

    }

}