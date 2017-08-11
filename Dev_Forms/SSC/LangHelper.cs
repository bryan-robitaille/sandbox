using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSC
{

    /// <summary>
    /// Declare this type in the namespace so it is available globally
    /// </summary>
    public enum Language { English, French };

    /// <summary>
    /// This class contains some helper functions for bilingual websites.
    /// Make sure to register the Application module in web.config so that the thread culture will be set appropriately
    /// - Language selection is based on the querystring parameter lang=en/fr
    /// - Assumes only English and French options
    /// </summary>
    public class LangHelper
    {

        /// <summary>
        /// Returns current language by calling GetCurrentLanguage()
        /// </summary>
        /// <returns>Language</returns>
        public static Language GetCurrentLanguage()
        {
            return URL.GetCurrentLangByURL();
        }

        /// <summary>
        /// Returns a short string representing the current selected language, either "en" or "fr"
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentLangStringShort()
        {
            return GetCurrentLanguage() == Language.French ? "fr" : "en";
        }

        /// <summary>
        /// Returns a long string representing the current selected language, either "English" or "French"
        /// </summary>
        /// <returns></returns>
        public static string GetCurrentLangStringLong()
        {
            return GetCurrentLanguage() == Language.French ? "French" : "English";
        }

        /// <summary>
        /// Sets culture based on GetCurrentLang()
        /// Must be called from Application_BeginRequest in global.asax for this LangHelper class to work.
        /// </summary>
        public static void SetCulture()
        {
            if (GetCurrentLanguage() == Language.French)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fr-CA");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fr-CA");
            }
            else
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-CA");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-CA");
            }
        }

    }

}