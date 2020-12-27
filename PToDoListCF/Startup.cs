using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PToDoListCF.Startup))]
namespace PToDoListCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
