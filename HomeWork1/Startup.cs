using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HamaDinSiteV.Startup))]
namespace HamaDinSiteV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //ConfigureAuth(app);
        }
    }
}
