using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Application.cs is used to attach the SSC.LangHelper.SetCulture() method to the Application_BeginRequest event
/// to eliminate dependency on that being set in the global.asax.
/// 
/// This module must be registerd in web.config
/// </summary>
public class Application : IHttpModule
{
    public Application()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string ModuleName
    {
        get { return "Application"; }
    }

    public void Init(HttpApplication application)
    {
        application.BeginRequest += (new EventHandler(this.Application_BeginRequest));
        application.EndRequest += (new EventHandler(this.Application_EndRequest));
    }

    private void Application_BeginRequest(Object source, EventArgs e)
    {
        SSC.Settings settings = new SSC.Settings();

        // Set Context on BeginRequest
        SSC.LangHelper.SetCulture();
    }

    private void Application_EndRequest(Object source, EventArgs e)
    {

    }

    public void Dispose() { }
}