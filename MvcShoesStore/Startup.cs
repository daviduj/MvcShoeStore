using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcShoesStore.Startup))]
namespace MvcShoesStore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
