using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AFG.Umbraco.Web.Startup))]
namespace AFG.Umbraco.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
