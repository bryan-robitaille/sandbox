<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ProgressBar_Test.aspx.cs" Inherits="Dev_Forms.ProgressBar_Test" %>


<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .ui-widget-header {
            background: #cedc98;
            border: 5px solid #DDDDDD;
            color: #333333;
            font-weight: bold;
        }
    </style>
     <section class="panel panel-default">
        <header class="panel-heading">
            <h3 class="panel-title">Description</h3>
        </header>
        <div class="panel-body">
            <p>This page demonstrates the ability to accurately feed server side progress of a long running process back to the browser without a complete page refresh.  This technology can also be used
                to create a custom chat feature.
            </p>
        </div>
    </section>
  
       <div class="col-md-12" style="padding-bottom: 50px">
        <button id="button1" type="button" class="btn, btn-primary btn-lg" style="display: none;">Click to Start Long Running Back-End Process</button>
        <div id="result" style="font-family: Tahoma; font-size: 0.9em; color: darkgray; display: none;">
            Initializing and Preparing...
        </div>
        <progress id="progressbar" class="col-md-6" value="0" max="100" style="display: none;"></progress>
    </div>
    
    

    <div id="Code">

        <div class="h3">Java Script Code:</div>
        <pre><code>
        $(function () {

            var progressNotifier = $.connection.progressHub;

            progressNotifier.client.sendMessage = function (message) {
                // update progress
                UpdateProgress(message);
            };

            $.connection.hub.logging = true;
            $.connection.hub.start().done(function () {
                $("#button1").show();
                $("#button1").click(function () {
                    $("#progressbar").attr("value", 0);
                    $("#result").show();
                    $("#progressbar").show();
                    progressNotifier.server.callLongOperation();
                })
            });        
        });
        
        function UpdateProgress(message) {
            // get result div
            var result = $("#result");
            // set message
            result.html(message);
            // get progress bar
            var value = parseInt($("#progressbar").attr("value"), 10);
            // update progress bar
            $("#progressbar").attr("value", value + 1);

        };
                 </code></pre>
        <div class="h3">C# .NET Hub code:</div>
        <pre><code>
        public class ProgressHub : Hub
    {
        private readonly ProgressBackEnd _BackEnd;
        public ProgressHub() : this(ProgressBackEnd.Instance) { }
        public string msg = "Initializing and Preparing...";
        public int count = 100;
        public ProgressHub(ProgressBackEnd BackEnd)
        {
            _BackEnd = BackEnd;
        }
        
        public void CallLongOperation()
        {
            _BackEnd.CallLongOperation(Context.ConnectionId);
        }
    }
         </code></pre>
        <div class="h3">C# .Net long running process class code:</div>
        <pre><code>
         public class ProgressBackEnd
    {
        //Setup Singleton Instance
        private readonly static Lazy&lt;ProgressBackEnd&gt; _instance = new Lazy&lt;ProgressBackEnd&gt;(() => new ProgressBackEnd(GlobalHost.ConnectionManager.GetHubContext&lt;ProgressHub&gt;().Clients));
        private ProgressBackEnd(IHubConnectionContext&lt;dynamic&gt; clients)
        {
            _Clients = clients;
        }
        private IHubConnectionContext&lt;dynamic&gt; _Clients
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
         </code></pre>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="DateModified" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="CustomScripts" runat="server">
    <script src="Scripts/jquery-2.2.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery-ui-1.11.4.min.js"></script>

    <%--  --%>
    <!-- signalr library -->
    <script src="Scripts/jquery.signalR-2.2.0.min.js"></script>

    <!-- autogenerated signalr hub script -->
    <script src='<%: ResolveClientUrl("~/signalr/hubs") %>'></script>

    <script type="text/javascript">
        $(function () {

            var progressNotifier = $.connection.progressHub;
            progressNotifier.client.sendMessage = function (message) {
                // update progress
                UpdateProgress(message);
            };
            $.connection.hub.logging = true;

            $.connection.hub.start().done(function () {
                $("#button1").show();
                $("#button1").click(function () {
                    $("#progressbar").attr("value", 0);
                    $("#result").show();
                    $("#progressbar").show();
                    progressNotifier.server.callLongOperation();
                })
            });



        });




        function UpdateProgress(message) {
            // get result div
            var result = $("#result");
            // set message
            result.html(message);
            // get progress bar
            var value = parseInt($("#progressbar").attr("value"), 10);
            // update progress bar
            $("#progressbar").attr("value", value + 1);

        };


    </script>
</asp:Content>
