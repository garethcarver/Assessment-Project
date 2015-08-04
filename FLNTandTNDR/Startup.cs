using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FLNTandTNDR.Startup))]
namespace FLNTandTNDR
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
