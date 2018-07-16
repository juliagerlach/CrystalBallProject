using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CrystalballProject.Startup))]
namespace CrystalballProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
