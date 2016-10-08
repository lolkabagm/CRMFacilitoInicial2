using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRMFacilitoInicial2.Startup))]
namespace CRMFacilitoInicial2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
