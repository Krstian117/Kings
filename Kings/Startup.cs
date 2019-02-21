using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kings.Startup))]
namespace Kings
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
