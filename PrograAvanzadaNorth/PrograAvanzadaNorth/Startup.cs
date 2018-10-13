using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PrograAvanzadaNorth.Startup))]
namespace PrograAvanzadaNorth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
