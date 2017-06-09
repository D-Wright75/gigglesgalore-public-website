using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GigglesGalore.Website.Web.Startup))]
namespace GigglesGalore.Website.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
