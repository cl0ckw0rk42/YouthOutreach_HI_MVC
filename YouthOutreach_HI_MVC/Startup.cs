using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouthOutreach_HI_MVC.Startup))]
namespace YouthOutreach_HI_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
