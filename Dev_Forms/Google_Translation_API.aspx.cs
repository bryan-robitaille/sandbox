using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dev_Forms
{
    public partial class Google_Translation_API : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string CreateRequest(string queryString, string source, string target)
        {
            string UrlRequest = "https://script.google.com/macros/s/AKfycbyL8w3wI-ly4HqUzL2fjso3QIqe-eCQ5g5iHwXj1YQgtsHSuXQR/exec?text=" + queryString + "&source=" + source 
                + "&target=" + target;
            return (UrlRequest);
        }

        protected void GetTrans_Click(object sender, EventArgs e)
        {
            TextBox Origin = sender as TextBox;
            
            
            if (Origin.ID.Contains("EngText"))
            {
                string DestinationID = Origin.ID.Replace("EngText", "FrenchText");
                string translation = CreateRequest(Origin.Text, "en", "fr");
                RegisterAsyncTask(new PageAsyncTask(() => MakeRequest(translation, DestinationID)));
            }
            if (Origin.ID.Contains("FrenchText"))
            {
                string DestinationID = Origin.ID.Replace("FrenchText", "EngText");
                string translation = CreateRequest(Origin.Text, "fr", "en");
                RegisterAsyncTask(new PageAsyncTask(() => MakeRequest(translation, DestinationID)));
            }


        }

        public async Task MakeRequest(string url, string destination)
        {

            using (HttpClient webClient = new HttpClient())
            {
                var response = await webClient.GetAsync(url);
                if (response.StatusCode != HttpStatusCode.OK)
                    throw new Exception(String.Format(
                    "Server error (HTTP {0}: {1}).",
                    response.StatusCode,
                    response.ReasonPhrase));

                DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RootObject));
                object objResponse = jsonSerializer.ReadObject(await response.Content.ReadAsStreamAsync());
                RootObject jsonResponse = objResponse as RootObject;
                UpdateTextBoxes(jsonResponse, destination);
            }

        }
        public void UpdateTextBoxes(RootObject json, string DestinationID)
        {
            TextBox Destination = (TextBox)BamBam.FindControl(DestinationID);
            if (Destination != null)
            {
                Destination.Text = json.translatedText;
            }
            else
            {
                Response.Write("Control " + DestinationID + " not found");
            }

        }


    }

    [DataContract]
    public class RootObject
    {
        [DataMember]
        public string sourceText { get; set; }
        [DataMember]
        public string translatedText { get; set; }
    }


}