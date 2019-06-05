using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RE.SistemaFaculdade.UI.Site.Startup))]
namespace RE.SistemaFaculdade.UI.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
