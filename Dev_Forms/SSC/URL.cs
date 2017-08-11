using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSC
{

    /// <summary>
    /// Summary description for URL
    /// </summary>
    public static class URL
    {

        /// <summary>
        /// Determines current language based on querystring parameter "lang"
        /// If querystring parameter lang=fr then current language is French.
        /// If querystring parameter doesn't exist or is invalid then default to English.
        /// </summary>
        /// <returns></returns>
        public static Language GetCurrentLangByURL()
        {
            // grab the querystring and make a NameValueCollection out of it
            System.Collections.Specialized.NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(HttpContext.Current.Request.Url.Query.ToString());
            return queryString["lang"] == "fr" ? Language.French : Language.English;
        }

        /// <summary>
        /// Returns an alternate-language url for language switching.
        /// ie, if the current language is English, this will return the URL to switch to French.
        /// Preserves querystring attributes.
        /// Called by GetLanguageSwitchLink()
        /// </summary>
        /// <returns></returns>
        public static string GetTranslatedURL()
        {
            // first get the left part of the URI
            string url = HttpContext.Current.Request.Url.ToString();
            Uri uri = new Uri(url);
            string baseURL = uri.GetLeftPart(UriPartial.Path);

            // get the query parameter collection and either add or change the "lang" parameter
            System.Collections.Specialized.NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(HttpContext.Current.Request.Url.Query.ToString());
            queryString["lang"] = LangHelper.GetCurrentLanguage() == Language.English ? "fr" : "en";

            // return the rebuilt url
            return baseURL + "?" + queryString.ToString();
        }

        /// <summary>
        /// Returns a hyperlink to alternate language uri
        /// ie: <a href="Default.aspx?lang=fr" lang="fr">Français</a>
        /// </summary>
        /// <returns></returns>
        public static string GetLanguageSwitchLink()
        {
            return String.Format(@"<a href=""{0}"" lang=""{1}"">{2}</a>", GetTranslatedURL(), LangHelper.GetCurrentLanguage() == Language.French ? "en" : "fr", LangHelper.GetCurrentLanguage() == Language.French ? "English" : "Français");
        }

    }

}