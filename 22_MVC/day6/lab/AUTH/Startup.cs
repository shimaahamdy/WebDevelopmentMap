using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AUTH.Startup))]
namespace AUTH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
