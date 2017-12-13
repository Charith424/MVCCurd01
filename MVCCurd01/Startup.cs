using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCurd01.Startup))]
namespace MVCCurd01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
