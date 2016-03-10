using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FoodTruckWebsite.Startup))]
namespace FoodTruckWebsite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
