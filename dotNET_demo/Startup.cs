using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dotNET_demo.Startup))]
namespace dotNET_demo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
