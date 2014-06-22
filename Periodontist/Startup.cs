using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Periodontist.Startup))]
namespace Periodontist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
