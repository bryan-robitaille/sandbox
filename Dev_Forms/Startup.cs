using Microsoft.Owin;
using Owin;
using Dev_Forms;

[assembly: OwinStartupAttribute(typeof(Dev_Forms.Startup))]
namespace Dev_Forms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
