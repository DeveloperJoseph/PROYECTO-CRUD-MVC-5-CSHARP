using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WHORES_PERU.Startup))]
namespace WHORES_PERU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
