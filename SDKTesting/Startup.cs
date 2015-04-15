using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SDKTesting.Startup))]
namespace SDKTesting
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
