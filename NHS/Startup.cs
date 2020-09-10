using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NHS.Startup))]
namespace NHS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
