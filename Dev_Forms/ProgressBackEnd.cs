using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System.Threading;

namespace Dev_Forms
{
    public class ProgressBackEnd
    {
        //Setup Singleton Instance
        private readonly static Lazy<ProgressBackEnd> _instance = new Lazy<ProgressBackEnd>(() => new ProgressBackEnd(GlobalHost.ConnectionManager.GetHubContext<ProgressHub>().Clients));
        private ProgressBackEnd(IHubConnectionContext<dynamic> clients)
        {
            _Clients = clients;
        }
        private IHubConnectionContext<dynamic> _Clients
        {
            get;
            set;
        }
        public static ProgressBackEnd Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        //Message broadcasting function
        private void Notify(string message, string ConnectionID)
        {
            _Clients.Client(ConnectionID).sendMessage(message);
        }

        //Actual code doing long work
        private int count = 100;
        private string msg = "Initializing and Preparing...";
        
        public void CallLongOperation(string ConID)
        {
            for (int x = 0; x <= count; x++)
            {

                // delay the process to see things clearly
                Thread.Sleep(100);

                if (x == 20)
                    msg = "Loading Application Settings...";

                else if (x == 40)
                    msg = "Applying Application Settings...";

                else if (x == 60)
                    msg = "Loading User Settings...";

                else if (x == 80)
                    msg = "Applying User Settings...";

                else if (x == 100)
                    msg = "Process Completed!...";

                // call client-side SendMethod method
                Notify(string.Format(msg + " {0}% of {1}%", x, count), ConID);
            }
        }

    }
}