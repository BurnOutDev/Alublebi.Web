using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Alublebi.Web.Public.Startup))]
namespace Alublebi.Web.Public
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
