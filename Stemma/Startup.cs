using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Stemma.Startup))]
namespace Stemma
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
