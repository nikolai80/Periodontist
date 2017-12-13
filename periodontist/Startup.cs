using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(periodontist.Startup))]
namespace periodontist
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
