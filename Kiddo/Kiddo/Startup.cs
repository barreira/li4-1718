using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kiddo.Startup))]
namespace Kiddo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
