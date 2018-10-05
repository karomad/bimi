using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BIMI.Web.Startup))]
namespace BIMI.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
