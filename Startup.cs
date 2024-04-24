using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EntityFremaworkPerformance.Startup))]
namespace EntityFremaworkPerformance
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
