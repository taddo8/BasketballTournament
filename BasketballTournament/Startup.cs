using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BasketballTournament.Startup))]
namespace BasketballTournament
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
