using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeiMA.OA.UI.Portal.Startup))]
namespace HeiMA.OA.UI.Portal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
