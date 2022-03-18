using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExternalLogins_42.Startup))]
namespace ExternalLogins_42
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
