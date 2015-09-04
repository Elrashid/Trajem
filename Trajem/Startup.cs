using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Trajem.Startup))]
namespace Trajem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
