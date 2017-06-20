using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRUDApp.Web.Startup))]
namespace CRUDApp.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
