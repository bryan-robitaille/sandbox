using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace SSC
{

    /// <summary>
    /// This helper extends the base Mailer to send templated emails.
    /// - Emails can contain replacement params to be populated with data before sending.
    /// -- Params have the format: {{ ParamName }}
    /// -- add params by  using the .AddParam("ParamName", "Param Value") method
    /// - Can have two different templates for either txt or html format.  Template name should be template.tpl or template.html.tpl
    /// -- Template files should be stored in a folder called EmailTemplates at root of site
    /// -- Trigger HTML template by setting property isHtml = true
    /// -- if HTML version doesn't exist an exception will be thrown
    ///       (should we attempt to load a non-html version??)
    ///       
    /// - i18n: If UserLanguage = true, will attempt to send an email in the currently selected language.
    /// -- Files should be named {name}.en/fr(.html).tpl
    /// -- If file does not exist in user's selected language, will default to base template {name}(.html).tpl
    /// 
    /// </summary>
    public class MailTemplateHelper : Mailer
    {

        /// <summary>
        /// Template - should be lowercase base name for email template stored in ~/EmailTemplates
        /// </summary>
        public string Template { get; set; }

        /// <summary>
        /// Send email in user's selected language?
        /// </summary>
        public bool UserLanguage { get; set; }

        private string _LangString { get; set; }

        private string _TemplateFile
        {
            get;
            set;
        }

        private Dictionary<string, string> _TemplateParams = new Dictionary<string, string>();

        public MailTemplateHelper()
        {

        }

        /// <summary>
        /// Add parameters to be parsed in email template
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="strValue"></param>
        public void AddParam(string Key, string Value)
        {
            this._TemplateParams.Add(Key, Value);
        }

        public override void send()
        {

            if (this.Template == null)
                throw new ArgumentException("Missing parameter: Template");

            if (this.UserLanguage)
            {
                this._LangString = SSC.LangHelper.GetCurrentLangStringShort();

                // try getting language-specific template file
                string LangFile = HttpContext.Current.Server.MapPath("~/EmailTemplates/" + this.Template + "." + _LangString + (this.isHtml ? ".html" : "") + ".tpl");
                if (File.Exists(LangFile))
                {
                    this._TemplateFile = LangFile;
                }
                else
                {
                    // Fall back to default file (no language specified)
                    LangFile = HttpContext.Current.Server.MapPath("~/EmailTemplates/" + this.Template + (this.isHtml ? ".html" : "") + ".tpl");
                    if (File.Exists(LangFile))
                    {
                        this._TemplateFile = LangFile;
                    }
                    else
                    {
                        // no file exception
                        throw new FileNotFoundException("Template File does not exist");
                    }
                }

            }
            else
            {
                // no language specified
                this._TemplateFile = HttpContext.Current.Server.MapPath("~/EmailTemplates/" + this.Template + (this.isHtml ? ".html" : "") + ".tpl");
                if (!File.Exists(_TemplateFile))
                {
                    throw new FileNotFoundException("Template File does not exist");
                }
            }

            // Load template file
            string EmailTemplate = File.ReadAllText(this._TemplateFile);

            // Replace template parameters
            foreach (var param in this._TemplateParams)
            {
                EmailTemplate = EmailTemplate.Replace("{{ " + param.Key + " }}", param.Value);
            }

            this.Body = EmailTemplate;

            base.send();

        }

    }

}