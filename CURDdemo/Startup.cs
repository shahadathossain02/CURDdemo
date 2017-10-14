using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CURDdemo.Startup))]
namespace CURDdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
