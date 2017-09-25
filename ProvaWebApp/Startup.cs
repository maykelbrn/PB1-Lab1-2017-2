using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProvaWebApp.Startup))]
namespace ProvaWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
