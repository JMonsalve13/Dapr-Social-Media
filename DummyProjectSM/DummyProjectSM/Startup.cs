using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DummyProjectSM.Startup))]
namespace DummyProjectSM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
