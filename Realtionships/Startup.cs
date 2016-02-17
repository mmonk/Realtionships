using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Realtionships.Startup))]
namespace Realtionships
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
