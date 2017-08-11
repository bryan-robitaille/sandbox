using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DataReporter.Startup))]
namespace DataReporter
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
