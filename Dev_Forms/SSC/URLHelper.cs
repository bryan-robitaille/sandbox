using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSC
{

    /// <summary>
    /// Summary description for URLHelper
    /// </summary>
    public static class URLHelper
    {
        public static string BaseURL = "";
        public static string URIParams = "";

        /// <summary>
        /// Ensures generated URL contains lang parameter for multilingual site
        /// </summary>
        /// <param name="dest"></param>
        /// <returns></returns>
        public static string Link(string dest)
        {
            string[] anchor = dest.Split('#');

            Uri link = GetUri(dest);

            string baseURL = link.GetLeftPart(UriPartial.Path);
            System.Collections.Specialized.NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(link.Query.ToString());

            queryString["lang"] = LangHelper.GetCurrentLangStringShort();

            return baseURL + "?" + queryString.ToString() + (anchor.Count() > 1 ? "#" + anchor[1].ToString() : "");
        }

        static private Uri GetUri(string URL)
        {
            // not going to work for a link directly to a file ie Default.aspx.  Must be ~/Default.aspx.  Should test/catch for this?

            //### Construct to proper URL
            if (!URL.ToLower().StartsWith("http"))
            {
                URL = VirtualPathUtility.ToAbsolute(URL);
                return new Uri(HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Authority + URL);
            }
            else
            {
                return new Uri(URL);
            }
        }

        /// <summary>
        /// Redirect to the specified resource, while maintaining selected lang parameter for multilingual site
        /// </summary>
        /// <param name="dest"></param>
        public static void Redirect(string dest)
        {

        }
    }

}