using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProperyPricer.Startup))]
namespace ProperyPricer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
