using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebFormsProducts.Startup))]
namespace WebFormsProducts
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
