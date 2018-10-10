using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CommunityService.Startup))]
namespace CommunityService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
